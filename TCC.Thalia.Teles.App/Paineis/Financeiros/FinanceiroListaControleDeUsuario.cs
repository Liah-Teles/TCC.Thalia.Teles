using System.Data;
using TCC.Thalia.Teles.Dominio.Features.Financeiros;

namespace TCC.Thalia.Teles.App.Paineis.Financeiros
{
    public partial class FinanceiroListaControleDeUsuario : UserControl
    {
        private ContratoFinanceiroRepositorio _repositorioArquivoCsvFinanceiro;
        private List<Financeiro> _listaConcluidosNoAno;
        private List<Financeiro> _listaFinanceiroMesSelecionado;
        private DateTime _ultimaDataSelecionada = default;

        public FinanceiroListaControleDeUsuario(ContratoFinanceiroRepositorio repositorioArquivoCsvFinanceiro)
        {
            InitializeComponent();
            _repositorioArquivoCsvFinanceiro = repositorioArquivoCsvFinanceiro;

            AtualizaGrid(DateTime.Now);
        }

        // ##########################################
        // Metodos
        // ##########################################

        public void AtualizaGrid(DateTime data)
        {
            gridAgendamentos.Rows.Clear();
            caixaTextoTotalParcial.Text = $"";
            caixaTextoDescontos.Text = $"";
            caixaTextoTotal.Text = $"";

            if (_ultimaDataSelecionada == default ||
               _ultimaDataSelecionada.Year != data.Year)
            {
                _listaConcluidosNoAno = _repositorioArquivoCsvFinanceiro.ObterTodosConcluidosNoAno(data.Year);
                _ultimaDataSelecionada = data;
            }

            _listaFinanceiroMesSelecionado = _listaConcluidosNoAno.Where(financeiro => financeiro.Agendamento.Data.Month == data.Month).ToList();


            decimal valoresParciaisGerais = 0;
            decimal descontosGerais = 0;
            decimal totalGeral = 0;

            foreach (var financeiro in _listaFinanceiroMesSelecionado)
            {
                var id = financeiro.Id;
                var cliente = financeiro.Agendamento.Cliente;
                var cpf = financeiro.Agendamento.ClienteCpf;
                var valorParcial = financeiro.ValorParcial;
                var valorDesconto = financeiro.DescontoAplicado;
                var valorTotal = financeiro.Total;

                valoresParciaisGerais += valorParcial;
                descontosGerais += valorDesconto;
                totalGeral += valorTotal;

                gridAgendamentos.Rows.Add(id, cliente, cpf, $"R$ {valorParcial}", $"R$ {valorDesconto}", $"R$ {valorTotal}");
            }

            caixaTextoTotalParcial.Text = $"R$ {valoresParciaisGerais}";
            caixaTextoDescontos.Text = $"R$ {descontosGerais}";
            caixaTextoTotal.Text = $"R$ {totalGeral}";
        }

        // ###############################################
        // Eventos dos componentes de listagem financeiro
        // ###############################################
        private void FinanceiroListaControleDeUsuario_Load(object sender, EventArgs e)
        {
            gridServicos.ClearSelection();
        }

        private void gridAgendamentos_SelectionChanged(object sender, EventArgs e)
        {
            gridServicos.Rows.Clear();

            if (gridAgendamentos.SelectedRows.Count != 0)
            {
                var agendamentoLinha = gridAgendamentos.SelectedRows[0];

                var idFinanceiroSelecionado = (int)agendamentoLinha.Cells[0].Value;

                var financeiroSelecionado = _listaFinanceiroMesSelecionado.FirstOrDefault(financeiro => financeiro.Id == idFinanceiroSelecionado);

                if (financeiroSelecionado == null)
                {
                    MessageBox.Show("Erro ao buscar agendamento selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    decimal totalServicos = 0M;
                    caixaTextoTotalServiços.Text = $"";
                    foreach (var servico in financeiroSelecionado.Agendamento.Servicos)
                    {
                        gridServicos.Rows.Add(servico.Nome, $"R$ {(servico.Valor + 0.00M)}");
                        totalServicos += servico.Valor;
                    }
                    gridServicos.ClearSelection();
                    caixaTextoTotalServiços.Text = $"R$ {totalServicos}";
                }
            }
        }

        private void caixaDataSelecionada_ValueChanged(object sender, EventArgs e)
        {
            AtualizaGrid(caixaDataSelecionada.Value);
        }
    }
}
