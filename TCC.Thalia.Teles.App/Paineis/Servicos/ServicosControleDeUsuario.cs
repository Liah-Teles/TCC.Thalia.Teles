using TCC.Thalia.Teles.Dominio.Features.Servicos;

namespace TCC.Thalia.Teles.App.Paineis.Servicos
{
    public partial class ServicosControleDeUsuario : UserControl
    {
        private ContratoServicoRepositorio _repositorioCsv;
        private List<Servico> _servicos;

        public ServicosControleDeUsuario(ContratoServicoRepositorio repositorioCsv)
        {
            InitializeComponent();
            _repositorioCsv = repositorioCsv;

            AtualizaGrid();
        }

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

        private void AdicionarListaNoGrid(List<Servico> servicos)
        {
            gridServicos.Rows.Clear();
            _servicos = servicos;
            foreach (var servico in servicos)
            {
                gridServicos.Rows.Add(servico.Id, servico.Nome, $"R$ {servico.Valor}");
            }
        }

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {

            try
            {
                var adicionarServicoTela = new AdicionarServicoTela(null);

                if (adicionarServicoTela.ShowDialog() == DialogResult.Yes)
                {
                    _repositorioCsv.Salvar(adicionarServicoTela.ObterServico());
                    MessageBox.Show("Inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizaGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botaoRemover_Click(object sender, EventArgs e)
        {
            if (gridServicos.SelectedRows.Count > 0)
            {
                var servicoLinha = gridServicos.SelectedRows[0];

                var id = int.Parse($"{servicoLinha.Cells[0].Value}");
                var nome = $"{servicoLinha.Cells[1].Value}";

                var resultado = MessageBox.Show($"Deseja realmente remover o serviço: {nome}?", "Atênção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    _repositorioCsv.Deletar(id);

                    AtualizaGrid();
                }
            }
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            if (gridServicos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um serviço para editar", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var servicoLinha = gridServicos.SelectedRows[0];

                    var idServicoSelecionado = (int)servicoLinha.Cells[0].Value;

                    var servico = _servicos.FirstOrDefault(serv => serv.Id == idServicoSelecionado);

                    var adicionarServicoTela = new AdicionarServicoTela(servico);

                    if (adicionarServicoTela.ShowDialog() == DialogResult.Yes)
                    {
                        _repositorioCsv.Atualizar(adicionarServicoTela.ObterServico());
                        MessageBox.Show("Atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizaGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ServicosControleDeUsuario_Load(object sender, EventArgs e)
        {
            gridServicos.ClearSelection();
            botaoEditar.Enabled = false;
            botaoRemover.Enabled = false;
        }

        private void gridServicos_SelectionChanged(object sender, EventArgs e)
        {
            botaoRemover.Enabled = true;
            botaoEditar.Enabled = true;
        }
    }
}
