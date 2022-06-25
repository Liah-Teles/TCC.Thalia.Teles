using TCC.Thalia.Teles.Dominio.Features.Atendimentos;
using TCC.Thalia.Teles.Dominio.Features.Descontos;
using TCC.Thalia.Teles.Dominio.Features.Financeiros;

namespace TCC.Thalia.Teles.App.Paineis.Financeiros
{
    public partial class FinanceiroControleDeUsuario : UserControl
    {
        private ContratoFinanceiroRepositorio _contratoFinanceiroRepositorio;
        private ContratoAtendimentoRepositorio _contratoAtendimentoRepositorio;
        private List<Atendimento> _atendimentos;
        private List<Desconto> _promocoes;
        private List<Desconto> _promocoesDentroDaLista = new List<Desconto>();

        public FinanceiroControleDeUsuario(ContratoFinanceiroRepositorio contratoFinanceiroRepositorio,
                                          ContratoAtendimentoRepositorio contratoAtendimentoRepositorio,
                                          List<Atendimento> atendimentos, List<Desconto> promocoes)
        {
            InitializeComponent();
            _contratoFinanceiroRepositorio = contratoFinanceiroRepositorio;
            _contratoAtendimentoRepositorio = contratoAtendimentoRepositorio;
            _atendimentos = atendimentos;
            _promocoes = promocoes;

            if (_atendimentos != null)
            {
                AdicionarListaNoGrid(_atendimentos);
            }
        }

        // ########################################
        // Metodos
        // ########################################

        private void AdicionarListaNoGrid(List<Atendimento> atendimentos)
        {
            gridAtendimentos.Rows.Clear();
            gridServicos.Rows.Clear();

            foreach (var atendimento in atendimentos)
            {
                gridAtendimentos.Rows.Add(atendimento.Id, atendimento.Cliente);
            }
        }

        private decimal AdicionaDescontosNaListaERetornaDescontos(Atendimento atendimentoSelecionado)
        {
            gridDescontos.Rows.Clear();
            decimal descontos = 0;
            if (_promocoes != null)
            {
                foreach (var desconto in _promocoes)
                {
                    if(atendimentoSelecionado.Data >= desconto.DataInicio && atendimentoSelecionado.Data <= desconto.DataFinal)
                    {
                        if (atendimentoSelecionado.Servicos.Any(servico => servico.Nome == desconto.NomeServico))
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

        private decimal AdicionaServicosERetornaValorDaSomaDeles(Atendimento atendimentoSelecionado)
        {
            gridServicos.Rows.Clear();
            decimal valorParcial = 0;

            foreach (var servico in atendimentoSelecionado.Servicos)
            {
                gridServicos.Rows.Add(servico.Id, servico.Nome);
                valorParcial += servico.Valor;
            }

            return valorParcial;
        }

        private Atendimento BuscaAtendimentoSelecionado()
        {
            var atendimentoLinha = gridAtendimentos.SelectedRows[0];

            var id = (int)atendimentoLinha.Cells[0].Value;

            return _atendimentos.FirstOrDefault(atendimento => atendimento.Id == id);
        }

        // ########################################
        // Eventos dos componentes de financeiro
        // ########################################

        private void gridAtendimentos_SelectionChanged(object sender, EventArgs e)
        {
            _promocoesDentroDaLista.Clear();

            if (gridAtendimentos.SelectedRows?.Count > 0)
            {
                Atendimento atendimentoSelecionado = BuscaAtendimentoSelecionado();

                if (atendimentoSelecionado == null)
                    return;

                var valorParcial = AdicionaServicosERetornaValorDaSomaDeles(atendimentoSelecionado);
                var descontos = AdicionaDescontosNaListaERetornaDescontos(atendimentoSelecionado);

                caixaTextoValorParcial.Text = $"R$ {valorParcial}";
                caixaTextoDesconto.Text = $"R$ {descontos}";
                caixaTextoTotal.Text = $"R$ {valorParcial - descontos}";
            }

        }

        private void botaoFinalizar_Click(object sender, EventArgs e)
        {
            if(_atendimentos == null || _atendimentos.Count == 0)
            {
                MessageBox.Show("Não existem atendimentos no dia de hoje para serem finalizados", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gridAtendimentos.SelectedRows?.Count == 0)
            {
                MessageBox.Show("Selecione um atendimento para finalizar", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var atendimentoSelecionado = BuscaAtendimentoSelecionado();

                if(atendimentoSelecionado.Data.Date != DateTime.Now.Date)
                {
                    MessageBox.Show("Não é possivel finalizar um atendimento com data diferente de hoje", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var desejaFinalizarAtendimento = MessageBox.Show("Deseja realmente finalizar o atendimento?", "Atênção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(desejaFinalizarAtendimento == DialogResult.No)
                    return;

                var financeiro = new Financeiro();

                financeiro.Total = decimal.Parse(caixaTextoTotal.Text.Replace("R$ ", ""));
                financeiro.ValorParcial = decimal.Parse(caixaTextoValorParcial.Text.Replace("R$ ", ""));
                financeiro.DescontoAplicado = decimal.Parse(caixaTextoDesconto.Text.Replace("R$ ", ""));
                atendimentoSelecionado.Concluido = true;
                financeiro.Atendimento = atendimentoSelecionado;
                financeiro.Descontos = _promocoesDentroDaLista;

                _contratoFinanceiroRepositorio.Salvar(financeiro);

                _contratoAtendimentoRepositorio.Atualizar(financeiro.Atendimento);

                MessageBox.Show("Finalizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AdicionarListaNoGrid(_contratoAtendimentoRepositorio.ObterTodos(financeiro.Atendimento.Data));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FinanceiroControleDeUsuario_Load(object sender, EventArgs e)
        {
            gridDescontos.ClearSelection();
            gridServicos.ClearSelection();
        }
    }
}
