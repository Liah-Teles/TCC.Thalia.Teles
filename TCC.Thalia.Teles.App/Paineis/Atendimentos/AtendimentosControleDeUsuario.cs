using TCC.Thalia.Teles.Dominio.Features.Atendimentos;
using TCC.Thalia.Teles.Dominio.Features.Clientes;
using TCC.Thalia.Teles.Dominio.Features.Servicos;

namespace TCC.Thalia.Teles.App.Paineis.Atendimentos
{
    public partial class AtendimentosControleDeUsuario : UserControl
    {
        private ContratoAtendimentoRepositorio _repositorioCsv;
        private ContratoServicoRepositorio _contratoServicoRepositorio;
        private ContratoClienteRepositorio _contratoClienteRepositorio;
        private List<Atendimento> _atendimentosNoGrid = new List<Atendimento>();
        private Atendimento _atendimentoSelecionado;

        public AtendimentosControleDeUsuario(ContratoAtendimentoRepositorio repositorioCsv,
                                            ContratoServicoRepositorio contratoServicoRepositorio,
                                            ContratoClienteRepositorio contratoClienteRepositorio)
        {
            InitializeComponent();

            _repositorioCsv = repositorioCsv;
            _contratoServicoRepositorio = contratoServicoRepositorio;
            _contratoClienteRepositorio = contratoClienteRepositorio;

            AtualizaGrid(DateTime.Now);
        }

        // ########################################
        // Metodos Privados

        private void AtualizaGrid(DateTime data)
        {
            try
            {
                _atendimentosNoGrid = _repositorioCsv.ObterTodos(data).Where(atendimento => atendimento.Data.Day == data.Day).ToList();

                AdicionarListaNoGrid(_atendimentosNoGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao atualizar grid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdicionarListaNoGrid(List<Atendimento> atendimentos)
        {
            gridAgenda.Rows.Clear();
            gridServicos.Rows.Clear();
            foreach (var atendimento in atendimentos)
            {
                gridAgenda.Rows.Add(atendimento.Id, $"{atendimento.Data.ToString("HH:mm")}", atendimento.Cliente, atendimento.ClienteCpf);
            }
        }


        // ###########################################
        // Eventos dos componentes da tela
        // ###########################################

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {

            try
            {
                var servicos = _contratoServicoRepositorio.ObterTodos();
                if (servicos == null || servicos.Count == 0)
                {
                    MessageBox.Show("Adicione serviços antes de realizar um atendimento", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var clientes = _contratoClienteRepositorio.ObterTodos();
                if (clientes == null || clientes.Count == 0)
                {
                    MessageBox.Show("Adicione clientes antes de realizar um atendimento", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var adicionarTela = new AdicionarAtendimentoTela(servicos, clientes, null);
                var resultadoDialogo = adicionarTela.ShowDialog();

                if (resultadoDialogo == DialogResult.Yes)
                {
                    _repositorioCsv.Salvar(adicionarTela.ObterAtendimento());
                    MessageBox.Show("Inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                AtualizaGrid(DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botaoRemover_Click(object sender, EventArgs e)
        {
            if (_atendimentoSelecionado == null)
            {
                MessageBox.Show("Selecione o atendimento para ser removido", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _repositorioCsv.Deletar(_atendimentoSelecionado.Id, _atendimentoSelecionado.Data);
            AtualizaGrid(calendario.SelectionStart);
            MessageBox.Show("Removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_atendimentoSelecionado == null)
                {
                    MessageBox.Show("Selecione o atendimento para ser editado", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var servicos = _contratoServicoRepositorio.ObterTodos();
                var clientes = _contratoClienteRepositorio.ObterTodos();
                
                var editarTela = new AdicionarAtendimentoTela(servicos, clientes, _atendimentoSelecionado);

                var resultadoDialogo = editarTela.ShowDialog();

                if (resultadoDialogo == DialogResult.Yes)
                {
                    _repositorioCsv.Atualizar(editarTela.ObterAtendimento());
                    MessageBox.Show("Atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                AtualizaGrid(_atendimentoSelecionado.Data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ###########################################
        // Eventos sem precisar de clicks
        // ###########################################

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            AtualizaGrid(e.Start);
        }

        private void gridAgenda_SelectionChanged(object sender, EventArgs e)
        {
            if (gridAgenda.SelectedRows != null && gridAgenda.SelectedRows.Count > 0)
            {
                gridServicos.Rows.Clear();

                var atendimentoLinha = gridAgenda.SelectedRows[0];

                var id = (int)atendimentoLinha.Cells[0].Value;

                _atendimentoSelecionado = _atendimentosNoGrid.First(atendimento => atendimento.Id == id);

                foreach (var servico in _atendimentoSelecionado.Servicos)
                {
                    gridServicos.Rows.Add(servico.Nome, $"R$ {servico.Valor}");
                }
                gridServicos.ClearSelection();

                botaoEditar.Enabled = true;
                botaoRemover.Enabled = true;
            }
        }

        private void AtendimentosControleDeUsuario_Load(object sender, EventArgs e)
        {
            gridAgenda.ClearSelection();
            gridServicos.ClearSelection();
            gridServicos.Rows.Clear();

            botaoEditar.Enabled = false;
            botaoRemover.Enabled = false;
        }
    }
}
