using System.Data;
using TCC.Thalia.Teles.Dominio.Features.Financeiros;

namespace TCC.Thalia.Teles.App.Paineis.Financeiros
{
    public partial class FinanceiroListaControleDeUsuario : UserControl
    {
        private ContratoFinanceiroRepositorio _contratoFinanceiroRepositorio;
        private List<Financeiro> _listaConcluidosNoAno;
        private List<Financeiro> _listaFinanceiroMesSelecionado;
        private DateTime _ultimaDataSelecionada = default;

        public FinanceiroListaControleDeUsuario(ContratoFinanceiroRepositorio contratoFinanceiroRepositorio)
        {
            InitializeComponent();
            _contratoFinanceiroRepositorio = contratoFinanceiroRepositorio;

            AtualizaGrid(DateTime.Now);
        }

        // ##########################################
        // Metodos
        // ##########################################

        public void AtualizaGrid(DateTime data)
        {
            gridAtendimentos.Rows.Clear();
            caixaTextoTotalParcial.Text = $"";
            caixaTextoDescontos.Text = $"";
            caixaTextoTotal.Text = $"";

            if (_ultimaDataSelecionada == default ||
               _ultimaDataSelecionada.Year != data.Year)
            {
                _listaConcluidosNoAno = _contratoFinanceiroRepositorio.ObterTodosConcluidosNoAno(data.Year);
                _ultimaDataSelecionada = data;
            }

            _listaFinanceiroMesSelecionado = _listaConcluidosNoAno.Where(financeiro => financeiro.Atendimento.Data.Month == data.Month).ToList();


            decimal valoresParciaisGerais = 0;
            decimal descontosGerais = 0;
            decimal totalGeral = 0;

            foreach (var financeiro in _listaFinanceiroMesSelecionado)
            {
                var id = financeiro.Id;
                var cliente = financeiro.Atendimento.Cliente;
                var cpf = financeiro.Atendimento.ClienteCpf;
                var valorParcial = financeiro.ValorParcial;
                var valorDesconto = financeiro.DescontoAplicado;
                var valorTotal = financeiro.Total;

                valoresParciaisGerais += valorParcial;
                descontosGerais += valorDesconto;
                totalGeral += valorTotal;

                gridAtendimentos.Rows.Add(id, cliente, cpf, $"R$ {valorParcial}", $"R$ {valorDesconto}", $"R$ {valorTotal}");
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

        private void gridAtendimentos_SelectionChanged(object sender, EventArgs e)
        {
            gridServicos.Rows.Clear();

            if (gridAtendimentos.SelectedRows.Count == 0)
            {
                return;
            }

            var atendimentoLinha = gridAtendimentos.SelectedRows[0];

            var idFinanceiroSelecionado = (int)atendimentoLinha.Cells[0].Value;

            var financeiroSelecionado = _listaFinanceiroMesSelecionado.FirstOrDefault(financeiro => financeiro.Id == idFinanceiroSelecionado);

            if (financeiroSelecionado == null)
            {
                MessageBox.Show("Erro ao buscar atendimento selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal totalServicos = 0M;
            caixaTextoTotalServiços.Text = $"";
            foreach (var servico in financeiroSelecionado.Atendimento.Servicos)
            {
                gridServicos.Rows.Add(servico.Nome, $"R$ {(servico.Valor + 0.00M)}");
                totalServicos += servico.Valor;
            }
            gridServicos.ClearSelection();
            caixaTextoTotalServiços.Text = $"R$ {totalServicos}";
        }

        private void caixaDataSelecionada_ValueChanged(object sender, EventArgs e)
        {
            AtualizaGrid(caixaDataSelecionada.Value);
        }
    }
}
