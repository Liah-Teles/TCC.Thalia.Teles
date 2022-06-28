using TCC.Thalia.Teles.Dominio.Features.Descontos;
using TCC.Thalia.Teles.Dominio.Features.Servicos;

namespace TCC.Thalia.Teles.App.Paineis.Descontos
{
    public partial class DescontosControleDeUsuario : UserControl
    {
        private ContratoDescontoRepositorio _repositorioCsvDescontos;
        private ContratoServicoRepositorio _repositorioCsvServico;
        public DescontosControleDeUsuario(ContratoDescontoRepositorio repositorioCsv, ContratoServicoRepositorio repositorioCsvServico)
        {
            InitializeComponent();
            _repositorioCsvDescontos = repositorioCsv;
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
                var todosDescontos = _repositorioCsvDescontos.ObterTodos();

                List<Desconto> descontosValidos = new List<Desconto>();

                foreach (var desconto in todosDescontos)
                {
                    if(desconto.DataFinal < DateTime.Now)
                    {
                        _repositorioCsvDescontos.Deletar(desconto.Id);
                    }

                    descontosValidos.Add(desconto);
                }

                AdicionarListaNoGrid(descontosValidos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao atualizar grid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdicionarListaNoGrid(List<Desconto> promocoes)
        {
            gridDescontos.Rows.Clear();
            foreach (var  desconto in promocoes)
            {
                gridDescontos.Rows.Add(desconto.Id, desconto.NomeServico, $"R$ {desconto.Valor}", desconto.DataInicio.ToString("dd/MM/yyyyy"), desconto.DataFinal.ToString("dd/MM/yyyyy"));
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
                    MessageBox.Show("Adicione serviços antes de criar uma desconto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var criarDescontoTela = new AdicionarDescontoTela(servicos);

                    var resultadoDialogo = criarDescontoTela.ShowDialog();

                    if (resultadoDialogo == DialogResult.Yes)
                    {
                        _repositorioCsvDescontos.Salvar(criarDescontoTela.ObterDesconto());
                        MessageBox.Show("Inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizaGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botaoRemover_Click(object sender, EventArgs e)
        {
            if (gridDescontos.SelectedRows.Count > 0)
            {
                var linha = gridDescontos.SelectedRows[0];

                var id = int.Parse($"{linha.Cells[0].Value}");
                var nome = $"{linha.Cells[1].Value}";

                var resultado = MessageBox.Show($"Deseja realmente remover a desconto: {nome}?", "Atênção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    _repositorioCsvDescontos.Deletar(id);
                    AtualizaGrid();
                }
            }
        }

        private void gridDescontos_SelectionChanged(object sender, EventArgs e)
        {
            botaoRemover.Enabled = true;
        }

        private void DescontosControleDeUsuario_Load(object sender, EventArgs e)
        {
            gridDescontos.ClearSelection();
            botaoRemover.Enabled = false;
        }
    }
}
