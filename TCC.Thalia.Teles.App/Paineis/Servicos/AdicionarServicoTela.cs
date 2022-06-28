using TCC.Thalia.Teles.Dominio.Features.Servicos;

namespace TCC.Thalia.Teles.App.Paineis.Servicos
{
    public partial class AdicionarServicoTela : Form
    {
        private Servico _servico;

        public AdicionarServicoTela(Servico servico)
        {
            InitializeComponent();

            if (servico != null)
            {
                _servico = servico;

                this.Text = "Editar serviço";
                caixaTextoNome.Text = servico.Nome;
                caixaTextoNome.Enabled = false;

                caixaNumericaValor.Value = servico.Valor;
            }
        }

        public Servico ObterServico()
        {
            return _servico;
        }
        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            if (_servico == null)
            {
                _servico = new Servico();
            }

            _servico.Nome = caixaTextoNome.Text;
            _servico.Valor = caixaNumericaValor.Value + 0.00M;

            var mensagem = _servico.ObterMensagemNaoValidado();

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
