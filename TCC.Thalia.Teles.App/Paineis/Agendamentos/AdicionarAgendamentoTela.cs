using TCC.Thalia.Teles.Dominio.Features.Agendamentos;
using TCC.Thalia.Teles.Dominio.Features.Clientes;
using TCC.Thalia.Teles.Dominio.Features.Servicos;

namespace TCC.Thalia.Teles.App.Paineis.Agendamentos
{
    public partial class AdicionarAgendamentoTela : Form
    {
        private Agendamento _agendamento;
        private List<Servico> _listaServicos;
        private List<Cliente> _listaClientes;
        private List<Servico> _listaServicosSelecionados;
        private Cliente _clienteSelecionado;

        public Agendamento ObterAgendamento()
        {
            return _agendamento;
        }

        public AdicionarAgendamentoTela(List<Servico> servicos,
                                        List<Cliente> clientes,
                                        Agendamento agendamento)
        {
            InitializeComponent();
            _listaServicos = servicos;
            _listaClientes = clientes;
            _listaServicosSelecionados = new List<Servico>();
            _agendamento = agendamento;

            AdicionarClientesNaCaixaDeListagem(clientes);

            AdicionarServicosAoGrid(servicos);
        }

        // ###############################################
        // Metodos
        // ###############################################
        private string RetornTextoParaListaCliente(string clienteNome, string clienteCpf)
        {
            return $"{clienteNome} | cpf: {clienteCpf}";
        }

        private bool VerificaSeTemErros()
        {
            if (_clienteSelecionado == null)
            {
                MessageBox.Show("Selecione um cliente para o agendamento", "Atênçao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (caixaDateHora.Value < DateTime.Now)
            {
                MessageBox.Show("Impossivel salvar agendamento com data inferior a hoje", "Atênçao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (caixaDateHora.Value > DateTime.Now.AddMonths(2))
            {
                MessageBox.Show("Só podem ser realizados agendamentos para no maximo em dois meses.", "Atênçao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if(_clienteSelecionado == null)
            {
                MessageBox.Show("Selecione um cliente", "Atênçao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void PopularCasoSejaEdicao()
        {
            if (_agendamento != null)
            {
                this.Text = "Editar agendamento";

                var clienteEmTexto = RetornTextoParaListaCliente(_agendamento.Cliente, _agendamento.ClienteCpf);

                caixaListaClientes.Text = clienteEmTexto;
                caixaListaClientes.Enabled = false;

                gridServicos.ClearSelection();

                foreach (DataGridViewRow row in gridServicos.Rows)
                {
                    var nomeServicoLinha = $"{row.Cells[0].Value}";

                    if (_agendamento.Servicos.Any(servico => servico.Nome == nomeServicoLinha))
                    {
                        row.Selected = true;
                    }
                }

                caixaDateHora.Value = _agendamento.Data;
            }
        }

        private void AdicionarClientesNaCaixaDeListagem(List<Cliente> clientes)
        {
            caixaListaClientes.Items.Clear();

            var clientesOrdenadosPorNome = clientes.OrderBy(cliente => cliente.Nome);

            foreach (var cliente in clientesOrdenadosPorNome)
            {
                caixaListaClientes.Items.Add(RetornTextoParaListaCliente(cliente.Nome, cliente.Cpf));
            }
        }

        private void AdicionarServicosAoGrid(List<Servico> servicos)
        {
            var servicoOrdenadosPorNome = servicos.OrderBy(servico => servico.Nome);
            foreach (var servico in servicoOrdenadosPorNome)
            {
                gridServicos.Rows.Add(servico.Nome, $"R$ {servico.Valor}");
            }
        }

        // ###############################################
        // Eventos componentes de adicionar agendamento
        // ###############################################
        private void caixaListaClientes_SelectedValueChanged(object sender, EventArgs e)
        {
            var clienteEmTextSelecionado = caixaListaClientes.Text;

            if (string.IsNullOrEmpty(clienteEmTextSelecionado))
                return;

            _clienteSelecionado = _listaClientes.First(cliente => clienteEmTextSelecionado == RetornTextoParaListaCliente(cliente.Nome, cliente.Cpf));
        }

        private void gridServicos_SelectionChanged(object sender, EventArgs e)
        {
            if (gridServicos.SelectedRows != null && gridServicos.SelectedRows.Count > 0)
            {
                _listaServicosSelecionados.Clear();

                foreach (DataGridViewRow linha in gridServicos.SelectedRows)
                {
                    var nomeServico = $"{linha.Cells[0].Value}";

                    var servico = _listaServicos.First(servico => servico.Nome == nomeServico);

                    _listaServicosSelecionados.Add(servico);
                }
            }
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            if(VerificaSeTemErros() == false)
            {
                if (_agendamento == null)
                {
                    _agendamento = new Agendamento();
                }

                _agendamento.Id = _agendamento.Id;
                _agendamento.Cliente = _clienteSelecionado.Nome;
                _agendamento.Data = caixaDateHora.Value;
                _agendamento.Servicos = _listaServicosSelecionados;
                _agendamento.ClienteCpf = _clienteSelecionado.Cpf;
                 _agendamento.Concluido = false;

                var mensagem = _agendamento.ObterMensagemNaoValidado();

                if (string.IsNullOrEmpty(mensagem))
                {
                    DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void AdicionarAgendamentoTela_Load(object sender, EventArgs e)
        {
            PopularCasoSejaEdicao();
        }
    }
}
