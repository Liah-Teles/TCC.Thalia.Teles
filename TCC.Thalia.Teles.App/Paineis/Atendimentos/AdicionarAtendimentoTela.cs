using TCC.Thalia.Teles.Dominio.Features.Atendimentos;
using TCC.Thalia.Teles.Dominio.Features.Clientes;
using TCC.Thalia.Teles.Dominio.Features.Servicos;

namespace TCC.Thalia.Teles.App.Paineis.Atendimentos
{
    public partial class AdicionarAtendimentoTela : Form
    {
        private Atendimento _atendimento;
        private List<Servico> _listaServicos;
        private List<Cliente> _listaClientes;
        private List<Servico> _listaServicosSelecionados;
        private Cliente _clienteSelecionado;

        public Atendimento ObterAtendimento()
        {
            return _atendimento;
        }

        public AdicionarAtendimentoTela(List<Servico> servicos,
                                        List<Cliente> clientes,
                                        Atendimento atendimento)
        {
            InitializeComponent();
            _listaServicos = servicos;
            _listaClientes = clientes;
            _listaServicosSelecionados = new List<Servico>();
            _atendimento = atendimento;

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
                MessageBox.Show("Selecione um cliente para o atendimento", "Atênçao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (caixaDateHora.Value < DateTime.Now)
            {
                MessageBox.Show("Impossivel salvar atendimento com data inferior a hoje", "Atênçao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (caixaDateHora.Value > DateTime.Now.AddMonths(2))
            {
                MessageBox.Show("Só podem ser realizados agendamentos para no maximo em dois meses.", "Atênçao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void PopularCasoSejaEdicao()
        {
            if (_atendimento != null)
            {
                this.Text = "Editar atendimento";

                var clienteEmTexto = RetornTextoParaListaCliente(_atendimento.Cliente, _atendimento.ClienteCpf);

                caixaListaClientes.Text = clienteEmTexto;
                caixaListaClientes.Enabled = false;

                gridServicos.ClearSelection();

                foreach (DataGridViewRow row in gridServicos.Rows)
                {
                    var nomeServicoLinha = $"{row.Cells[0].Value}";

                    if (_atendimento.Servicos.Any(servico => servico.Nome == nomeServicoLinha))
                    {
                        row.Selected = true;
                    }
                }

                caixaDateHora.Value = _atendimento.Data;
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
        // Eventos componentes de adicionar atendimento
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
            if (gridServicos.SelectedRows == null || gridServicos.SelectedRows.Count == 0)
            {
                return;
            }
            _listaServicosSelecionados.Clear();

            foreach (DataGridViewRow linha in gridServicos.SelectedRows)
            {
                var nomeServico = $"{linha.Cells[0].Value}";

                var servico = _listaServicos.First(servico => servico.Nome == nomeServico);

                _listaServicosSelecionados.Add(servico);
            }
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            if(VerificaSeTemErros())
                return;

            int id = 0;

            if (_atendimento != null)
            {
                id = _atendimento.Id;
            }

            _atendimento = new Atendimento()
            {
                Id = id,
                Cliente = _clienteSelecionado?.Nome,
                Data = caixaDateHora.Value,
                Servicos = _listaServicosSelecionados,
                ClienteCpf = _clienteSelecionado.Cpf,
                Concluido = false,
            };

            var mensagem = _atendimento.ObterMensagemNaoValidado();

            if (string.IsNullOrEmpty(mensagem))
            {
                DialogResult = DialogResult.Yes;
                return;
            }

            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AdicionarAtendimentoTela_Load(object sender, EventArgs e)
        {
            PopularCasoSejaEdicao();
        }
    }
}
