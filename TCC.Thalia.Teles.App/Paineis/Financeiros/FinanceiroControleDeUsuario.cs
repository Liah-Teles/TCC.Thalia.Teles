using TCC.Thalia.Teles.Dominio.Features.Agendamentos;
using TCC.Thalia.Teles.Dominio.Features.Descontos;
using TCC.Thalia.Teles.Dominio.Features.Financeiros;

namespace TCC.Thalia.Teles.App.Paineis.Financeiros
{
    public partial class FinanceiroControleDeUsuario : UserControl
    {
        private ContratoFinanceiroRepositorio _contratoFinanceiroRepositorio;
        private ContratoAgendamentoRepositorio _contratoAgendamentoRepositorio;
        private List<Agendamento> _agendamentos;
        private List<Desconto> _promocoes;
        private List<Desconto> _promocoesDentroDaLista = new List<Desconto>();

        public FinanceiroControleDeUsuario(ContratoFinanceiroRepositorio repositorioArquivoCsvFinanceiro,
                                          ContratoAgendamentoRepositorio repositorioArquivoCsvAgendamento,
                                          List<Agendamento> agendamentos, List<Desconto> promocoes)
        {
            InitializeComponent();
            _contratoFinanceiroRepositorio = repositorioArquivoCsvFinanceiro;
            _contratoAgendamentoRepositorio = repositorioArquivoCsvAgendamento;
            _agendamentos = agendamentos;
            _promocoes = promocoes;

            if (_agendamentos != null)
            {
                AdicionarListaNoGrid(_agendamentos);
            }
        }

        // ########################################
        // Metodos
        // ########################################

        private void AdicionarListaNoGrid(List<Agendamento> agendamentos)
        {
            gridAgendamentos.Rows.Clear();
            gridServicos.Rows.Clear();

            foreach (var agendamento in agendamentos)
            {
                gridAgendamentos.Rows.Add(agendamento.Id, agendamento.Cliente);
            }
        }

        private decimal AdicionaDescontosNaListaERetornaDescontos(Agendamento agendamentoSelecionado)
        {
            gridDescontos.Rows.Clear();
            decimal descontos = 0;

            if (_promocoes != null)
            {
                foreach (var desconto in _promocoes)
                {
                    if (agendamentoSelecionado.Data >= desconto.DataInicio && agendamentoSelecionado.Data <= desconto.DataFinal)
                    {
                        if (agendamentoSelecionado.Servicos.Any(servico => servico.Nome == desconto.NomeServico))
                        {
                            gridDescontos.Rows.Add(desconto.NomeServico, $"R$ {desconto.Valor}");

                            descontos += desconto.Valor;
                            _promocoesDentroDaLista.Add(desconto);
                        }
                    }
                }
            }

            return descontos;
        }

        private decimal AdicionaServicosERetornaValorDaSomaDeles(Agendamento agendamentoSelecionado)
        {
            gridServicos.Rows.Clear();
            decimal valorParcial = 0;

            foreach (var servico in agendamentoSelecionado.Servicos)
            {
                gridServicos.Rows.Add(servico.Id, servico.Nome);
                valorParcial += servico.Valor;
            }

            return valorParcial;
        }

        private Agendamento BuscaAgendamentoSelecionado()
        {
            var agendamentoLinha = gridAgendamentos.SelectedRows[0];

            var id = int.Parse($"{agendamentoLinha.Cells[0].Value}");

            return _agendamentos.FirstOrDefault(agendamento => agendamento.Id == id);
        }

        // ########################################
        // Eventos dos componentes de financeiro
        // ########################################

        private void gridAgendamentos_SelectionChanged(object sender, EventArgs e)
        {
            _promocoesDentroDaLista.Clear();

            if (gridAgendamentos.SelectedRows?.Count > 0)
            {
                Agendamento agendamentoSelecionado = BuscaAgendamentoSelecionado();

                if (agendamentoSelecionado != null)
                {
                    var valorParcial = AdicionaServicosERetornaValorDaSomaDeles(agendamentoSelecionado);
                    var descontos = AdicionaDescontosNaListaERetornaDescontos(agendamentoSelecionado);

                    caixaTextoValorParcial.Text = $"R$ {valorParcial}";
                    caixaTextoDesconto.Text = $"R$ {descontos}";
                    caixaTextoTotal.Text = $"R$ {valorParcial - descontos}";
                }
            }

        }

        private void botaoFinalizar_Click(object sender, EventArgs e)
        {
            if (_agendamentos == null || _agendamentos.Count == 0)
            {
                MessageBox.Show("Não existem agendamentos no dia de hoje para serem finalizados", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gridAgendamentos.SelectedRows?.Count == 0)
            {
                MessageBox.Show("Selecione um agendamento para finalizar", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var agendamentoSelecionado = BuscaAgendamentoSelecionado();

                    if (agendamentoSelecionado.Data.Date != DateTime.Now.Date)
                    {
                        MessageBox.Show("Não é possivel finalizar um agendamento com data diferente de hoje", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var desejaFinalizarAgendamento = MessageBox.Show("Deseja realmente finalizar o agendamento?", "Atênção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (desejaFinalizarAgendamento == DialogResult.Yes)
                        {
                            var financeiro = new Financeiro();

                            financeiro.Total = decimal.Parse(caixaTextoTotal.Text.Replace("R$ ", ""));
                            financeiro.ValorParcial = decimal.Parse(caixaTextoValorParcial.Text.Replace("R$ ", ""));
                            financeiro.DescontoAplicado = decimal.Parse(caixaTextoDesconto.Text.Replace("R$ ", ""));
                            agendamentoSelecionado.Concluido = true;
                            financeiro.Agendamento = agendamentoSelecionado;
                            financeiro.Descontos = _promocoesDentroDaLista;

                            _contratoFinanceiroRepositorio.Salvar(financeiro);

                            _contratoAgendamentoRepositorio.Atualizar(financeiro.Agendamento);

                            MessageBox.Show("Finalizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            var listaAgendamentos = _contratoAgendamentoRepositorio.ObterTodos(financeiro.Agendamento.Data);
                            AdicionarListaNoGrid(listaAgendamentos);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FinanceiroControleDeUsuario_Load(object sender, EventArgs e)
        {
            gridDescontos.ClearSelection();
            gridServicos.ClearSelection();
        }
    }
}
