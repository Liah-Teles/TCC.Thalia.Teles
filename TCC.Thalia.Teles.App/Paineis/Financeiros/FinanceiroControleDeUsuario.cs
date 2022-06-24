using TCC.Thalia.Teles.Dominio.Features.Atendimentos;
using TCC.Thalia.Teles.Dominio.Features.Financeiros;
using TCC.Thalia.Teles.Dominio.Features.Promocoes;

namespace TCC.Thalia.Teles.App.Paineis.Financeiros
{
    public partial class FinanceiroControleDeUsuario : UserControl
    {
        private ContratoFinanceiroRepositorio _contratoFinanceiroRepositorio;
        private ContratoAtendimentoRepositorio _contratoAtendimentoRepositorio;
        private List<Atendimento> _atendimentos;
        private List<Promocao> _promocoes;
        private List<Promocao> _promocoesDentroDaLista = new List<Promocao>();

        public FinanceiroControleDeUsuario(ContratoFinanceiroRepositorio contratoFinanceiroRepositorio,
                                          ContratoAtendimentoRepositorio contratoAtendimentoRepositorio,
                                          List<Atendimento> atendimentos, List<Promocao> promocoes)
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

        private decimal AdicionaPromocoesNaListaERetornaDescontos(Atendimento atendimentoSelecionado)
        {
            decimal descontos = 0;
            if (_promocoes != null)
            {
                foreach (var promocao in _promocoes)
                {
                    if (atendimentoSelecionado.Servicos.Any(servico => servico.Nome == promocao.NomeServico))
                    {
                        caixaListaPromocoes.Items.Add($"promoção serviço: {promocao.NomeServico} | R$ {promocao.Desconto}");

                        descontos += promocao.Desconto;
                        _promocoesDentroDaLista.Add(promocao);
                    }
                }
            }

            return descontos;
        }

        private decimal AdicionaServicosERetornaValorDaSomaDeles(Atendimento atendimentoSelecionado)
        {
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
            caixaListaPromocoes.Items.Clear();
            gridServicos.Rows.Clear();
            _promocoesDentroDaLista.Clear();

            if (gridAtendimentos.SelectedRows?.Count > 0)
            {
                Atendimento atendimentoSelecionado = BuscaAtendimentoSelecionado();

                if (atendimentoSelecionado == null)
                    return;

                var valorParcial = AdicionaServicosERetornaValorDaSomaDeles(atendimentoSelecionado);
                var descontos = AdicionaPromocoesNaListaERetornaDescontos(atendimentoSelecionado);

                caixaTextoValorParcial.Text = $"{valorParcial}";
                caixaTextoDesconto.Text = $"{descontos}";
                caixaTextoTotal.Text = $"{valorParcial - descontos}";
            }

        }

        private void botaoFinalizar_Click(object sender, EventArgs e)
        {

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

                var financeiro = new Financeiro();

                financeiro.Total = decimal.Parse(caixaTextoTotal.Text);
                financeiro.ValorParcial = decimal.Parse(caixaTextoValorParcial.Text);
                financeiro.DescontoAplicado = decimal.Parse(caixaTextoDesconto.Text);
                atendimentoSelecionado.Concluido = true;
                financeiro.Atendimento = atendimentoSelecionado;
                financeiro.Promocoes = _promocoesDentroDaLista;

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
    }
}
