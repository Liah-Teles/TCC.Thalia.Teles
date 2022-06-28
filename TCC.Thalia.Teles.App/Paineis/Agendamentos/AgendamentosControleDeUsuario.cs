using TCC.Thalia.Teles.Dominio.Features.Agendamentos;
using TCC.Thalia.Teles.Dominio.Features.Clientes;
using TCC.Thalia.Teles.Dominio.Features.Servicos;

namespace TCC.Thalia.Teles.App.Paineis.Agendamentos
{
    public partial class AgendamentosControleDeUsuario : UserControl
    {
        private ContratoAgendamentoRepositorio _repositorioCsv;
        private ContratoServicoRepositorio _contratoServicoRepositorio;
        private ContratoClienteRepositorio _contratoClienteRepositorio;
        private List<Agendamento> _agendamentosNoGrid = new List<Agendamento>();
        private Agendamento _agendamentoSelecionado;

        public AgendamentosControleDeUsuario(ContratoAgendamentoRepositorio repositorioCsv,
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
                _agendamentosNoGrid = _repositorioCsv.ObterTodos(data).Where(agendamento => agendamento.Data.Day == data.Day).ToList();

                AdicionarListaNoGrid(_agendamentosNoGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao atualizar grid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdicionarListaNoGrid(List<Agendamento> agendamentos)
        {
            gridAgenda.Rows.Clear();
            gridServicos.Rows.Clear();
            foreach (var agendamento in agendamentos)
            {
                gridAgenda.Rows.Add(agendamento.Id, $"{agendamento.Data.ToString("HH:mm")}", agendamento.Cliente, agendamento.ClienteCpf);
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
                    MessageBox.Show("Adicione serviços antes de realizar um agendamento", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var clientes = _contratoClienteRepositorio.ObterTodos();

                    if (clientes == null || clientes.Count == 0)
                    {
                        MessageBox.Show("Adicione clientes antes de realizar um agendamento", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var adicionarTela = new AdicionarAgendamentoTela(servicos, clientes, null);
                        var resultadoDialogo = adicionarTela.ShowDialog();

                        if (resultadoDialogo == DialogResult.Yes)
                        {
                            _repositorioCsv.Salvar(adicionarTela.ObterAgendamento());
                            MessageBox.Show("Inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        AtualizaGrid(DateTime.Now);
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
            if (_agendamentoSelecionado == null)
            {
                MessageBox.Show("Selecione o agendamento para ser removido", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _repositorioCsv.Deletar(_agendamentoSelecionado.Id, _agendamentoSelecionado.Data);
                MessageBox.Show("Removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizaGrid(calendario.SelectionStart);
            }
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_agendamentoSelecionado == null)
                {
                    MessageBox.Show("Selecione o agendamento para ser editado", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    var servicos = _contratoServicoRepositorio.ObterTodos();
                    var clientes = _contratoClienteRepositorio.ObterTodos();

                    var editarTela = new AdicionarAgendamentoTela(servicos, clientes, _agendamentoSelecionado);

                    var resultadoDialogo = editarTela.ShowDialog();

                    if (resultadoDialogo == DialogResult.Yes)
                    {
                        _repositorioCsv.Atualizar(editarTela.ObterAgendamento());
                        MessageBox.Show("Atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizaGrid(_agendamentoSelecionado.Data);
                    }
                }
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

                var agendamentoLinha = gridAgenda.SelectedRows[0];

                var id = int.Parse($"{agendamentoLinha.Cells[0].Value}");

                _agendamentoSelecionado = _agendamentosNoGrid.First(agendamento => agendamento.Id == id);

                foreach (var servico in _agendamentoSelecionado.Servicos)
                {
                    gridServicos.Rows.Add(servico.Nome, $"R$ {servico.Valor}");
                }
                gridServicos.ClearSelection();

                botaoEditar.Enabled = true;
                botaoRemover.Enabled = true;
            }
        }

        private void AgendamentosControleDeUsuario_Load(object sender, EventArgs e)
        {
            gridAgenda.ClearSelection();
            gridServicos.ClearSelection();
            gridServicos.Rows.Clear();

            botaoEditar.Enabled = false;
            botaoRemover.Enabled = false;
        }
    }
}
