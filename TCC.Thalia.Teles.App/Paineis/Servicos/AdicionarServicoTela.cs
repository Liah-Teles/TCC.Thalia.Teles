using TCC.Thalia.Teles.Dominio.Features.Servicos;

namespace TCC.Thalia.Teles.App.Paineis.Servicos
{
    public partial class AdicionarServicoTela : Form
    {
        private Servico _servico;
        private int _id = 0;

        public AdicionarServicoTela(Servico servico)
        {
            InitializeComponent();

            if (servico != null)
            {
                this.Text = "Editar serviço";
                caixaTextoNome.Text = servico.Nome;
                caixaTextoNome.Enabled = false;

                caixaNumericaValor.Value = servico.Valor;

                _servico = servico;
                _id = servico.Id;
            }
        }

        public Servico ObterServico()
        {
            return _servico;
        }
        private void botaoSalvar_Click(object sender, EventArgs e)
        {

            _servico = new Servico
            {
                Id = _id,
                Nome = caixaTextoNome.Text,
                Valor = caixaNumericaValor.Value + 0.00M
            };

            var mensagem = _servico.ObterMensagemNaoValidado();

            if (string.IsNullOrEmpty(mensagem))
            {
                DialogResult = DialogResult.Yes;
                return;
            }

            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
