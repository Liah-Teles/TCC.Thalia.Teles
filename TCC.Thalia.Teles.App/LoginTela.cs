using System.Text.Json;
using TCC.Thalia.Teles.App.Configuracoes;

namespace TCC.Thalia.Teles.App
{
    public partial class LoginTela : Form
    {
        private Configuracao _configuracao;
        public LoginTela()
        {
            InitializeComponent();
            var configuracaoJson = File.ReadAllText("Configuracoes\\configuracao.json");

            _configuracao = JsonSerializer.Deserialize<Configuracao>(configuracaoJson);
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoLogin_Click(object sender, EventArgs e)
        {
            if (caixaDeTextoUsuario.Text == _configuracao.Login.Usuario && caixaDeTextoPassword.Text == _configuracao.Login.Senha)
            {
                var telaPrincipal = new PrincipalTela();
                this.Hide();
                telaPrincipal.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Usuário ou senha invalidos.", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
