using TCC.Thalia.Teles.Dominio.Features.Promocoes;
using TCC.Thalia.Teles.Dominio.Features.Servicos;

namespace TCC.Thalia.Teles.App.Paineis.Promocoes
{
    public partial class PromocoesControleDeUsuario : UserControl
    {
        private ContratoPromocaoRepositorio _repositorioCsv;
        private ContratoServicoRepositorio _repositorioCsvServico;
        public PromocoesControleDeUsuario(ContratoPromocaoRepositorio repositorioCsv, ContratoServicoRepositorio repositorioCsvServico)
        {
            InitializeComponent();
            _repositorioCsv = repositorioCsv;
            _repositorioCsvServico = repositorioCsvServico;

            AtualizaGrid();
        }

        // #############################################
        // Metodos
        // #############################################

        private void AtualizaGrid()
        {
            try
            {
                AdicionarListaNoGrid(_repositorioCsv.ObterTodos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao atualizar grid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdicionarListaNoGrid(List<Promocao> promocoes)
        {
            gridPromocoes.Rows.Clear();
            foreach (var  promocao in promocoes)
            {
                gridPromocoes.Rows.Add(promocao.Id, promocao.NomeServico, promocao.Desconto);
            }
        }

        // #############################################
        // Eventos componentes da tela de promoções
        // #############################################

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var servicos = _repositorioCsvServico.ObterTodos();

                if (servicos == null || servicos.Count == 0)
                {
                    MessageBox.Show("Adicione serviços antes de criar uma promoção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var criarPromocaoTela = new AdicionarPromocoesTela(servicos);

                var resultadoDialogo = criarPromocaoTela.ShowDialog();

                if (resultadoDialogo == DialogResult.Yes)
                {
                    _repositorioCsv.Salvar(criarPromocaoTela.ObterPromocao());
                    MessageBox.Show("Inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                AtualizaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botaoRemover_Click(object sender, EventArgs e)
        {
            if (gridPromocoes.SelectedRows.Count > 0)
            {
                var linha = gridPromocoes.SelectedRows[0];

                var id = (int)linha.Cells[0].Value;
                var nome = linha.Cells[1].Value;

                var resultado = MessageBox.Show($"Deseja realmente remover a promoção: {nome}?", "Atênção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    _repositorioCsv.Deletar(id);

                    AtualizaGrid();
                }
            }
        }

        private void gridPromocoes_SelectionChanged(object sender, EventArgs e)
        {
            botaoRemover.Enabled = true;
        }

        private void PromocoesControleDeUsuario_Load(object sender, EventArgs e)
        {
            gridPromocoes.ClearSelection();
            botaoRemover.Enabled = false;
        }
    }
}
