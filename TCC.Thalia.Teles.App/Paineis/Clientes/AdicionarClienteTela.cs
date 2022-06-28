using TCC.Thalia.Teles.Dominio.Features.Clientes;

namespace TCC.Thalia.Teles.App.Paineis.Clientes
{
    public partial class AdicionarClienteTela : Form
    {
        private Cliente _cliente;

        public AdicionarClienteTela(Cliente cliente)
        {
            InitializeComponent();

            _cliente = cliente;

            if (_cliente != null)
            {
                this.Text = "Editar cliente";
                caixaDeTextoNome.Text = _cliente.Nome;
                caixaDeTextoEndereco.Text = _cliente.Endereco;
                caixaTextoMascaraCelular.Text = _cliente.Celular;
                caixaTextoMascaraCpf.Text = _cliente.Cpf;
            }
        }

        public Cliente ObterCliente()
        {
            return _cliente;
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            if(_cliente == null)
            {
                _cliente = new Cliente();
            }

            _cliente = new Cliente
            {
                Id = _cliente.Id,
                Nome = caixaDeTextoNome.Text,
                Endereco = caixaDeTextoEndereco.Text,
                Celular = caixaTextoMascaraCelular.Text,
                Cpf = caixaTextoMascaraCpf.Text.Replace(",", ".")
            };

            var mensagem = _cliente.ObterMensagemNaoValidado();

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
}
