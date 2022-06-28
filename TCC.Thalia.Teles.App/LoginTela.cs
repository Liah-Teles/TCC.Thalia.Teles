using System.Text.Json;
using TCC.Thalia.Teles.App.Confs;

namespace TCC.Thalia.Teles.App
{
    public partial class LoginTela : Form
    {
        private Configuracao _configuracao;
        public LoginTela()
        {
            InitializeComponent();
            var configuracaoJson = File.ReadAllText("Confs\\conf.json");

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
                telaPrincipal.Focus();
                telaPrincipal.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Usuário ou senha invalidos.", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void etiquetaMudarSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modifique no arquivo em: 'Confs\\conf.json", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
