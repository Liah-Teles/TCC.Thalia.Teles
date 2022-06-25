using TCC.Thalia.Teles.Dominio.Features.Atendimentos;
using TCC.Thalia.Teles.Dominio.Features.Clientes;

namespace TCC.Thalia.Teles.App.Paineis.Clientes
{
    public partial class ClientesControleDeUsuario : UserControl
    {
        private ContratoClienteRepositorio _repositorioCsv;
        private ContratoAtendimentoRepositorio _contratoAtendimentoRepositorio;

        public ClientesControleDeUsuario(ContratoClienteRepositorio repositorioCsv, ContratoAtendimentoRepositorio contratoAtendimentoRepositorio)
        {
            InitializeComponent();

            _repositorioCsv = repositorioCsv;
            _contratoAtendimentoRepositorio = contratoAtendimentoRepositorio;

            AtualizaGrid();
        }

        // ####################################################
        // Metodos
        // ####################################################

        private void AtualizaGrid()
        {
            try
            {
                AdicionarListaClientesNoGrid(_repositorioCsv.ObterTodos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao atualizar grid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdicionarListaClientesNoGrid(List<Cliente> clientes)
        {
            gridClientes.Rows.Clear();
            foreach (Cliente cliente in clientes)
            {
                gridClientes.Rows.Add(cliente.Id, cliente.Nome, cliente.Celular, cliente.Cpf, cliente.Endereco);
            }
        }

        // ####################################################
        // Eventos dos componentes da tela de clientes
        // ####################################################

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var adicionarClienteTela = new AdicionarClienteTela(null);
                var resultadoDialogo = adicionarClienteTela.ShowDialog();

                if (resultadoDialogo == DialogResult.Yes)
                {
                    _repositorioCsv.Salvar(adicionarClienteTela.ObterCliente());
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
            if (gridClientes.SelectedRows.Count > 0)
            {
                var clienteLinha = gridClientes.SelectedRows[0];

                var idCliente = (int)clienteLinha.Cells[0].Value;
                var nomeCliente = clienteLinha.Cells[1].Value;
                var cpfCliente = clienteLinha.Cells[3].Value;

                var resultado = MessageBox.Show($"Apagar cliente: {nomeCliente} irá remover todos os agendamentos do mesmo, continuar?", "Atênção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    _repositorioCsv.Deletar(idCliente);
                    _contratoAtendimentoRepositorio.DeletarPorCpfCliente($"{cpfCliente}");

                    AtualizaGrid();
                }
            }
        }

        private void gridClientes_MouseDown(object sender, MouseEventArgs e)

        {
            botaoRemover.Enabled = false;
            botaoEditar.Enabled = false;
            if (gridClientes.SelectedRows.Count > 0)
            {
                botaoRemover.Enabled = true;
                botaoEditar.Enabled = true;
            }
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {

            try
            {
                if (gridClientes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um cliente para editar!", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var clienteLinha = gridClientes.SelectedRows[0];

                var id = (int)clienteLinha.Cells[0].Value;
                var nomeCliente = $"{clienteLinha.Cells[1].Value}";
                var celular = $"{clienteLinha.Cells[2].Value}";
                var documento = $"{clienteLinha.Cells[3].Value}";
                var endereco = $"{clienteLinha.Cells[4].Value}";

                var cliente = new Cliente
                {
                    Id = id,
                    Nome = nomeCliente,
                    Celular = celular,
                    Cpf = documento,
                    Endereco = endereco,
                };

                var adicionarClienteTela = new AdicionarClienteTela(cliente);
                var resultadoDialogo = adicionarClienteTela.ShowDialog();

                if (resultadoDialogo == DialogResult.Yes)
                {
                    _repositorioCsv.Atualizar(adicionarClienteTela.ObterCliente());
                    MessageBox.Show("Atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                AtualizaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridClientes_SelectionChanged(object sender, EventArgs e)
        {
            botaoEditar.Enabled = true;
            botaoRemover.Enabled = true;
        }

        private void ClientesControleDeUsuario_Load(object sender, EventArgs e)
        {
            gridClientes.ClearSelection();
            botaoEditar.Enabled = false;
            botaoRemover.Enabled = false;
        }
    }
}
