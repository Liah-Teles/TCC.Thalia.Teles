using TCC.Thalia.Teles.App.Paineis.Atendimentos;
using TCC.Thalia.Teles.App.Paineis.Clientes;
using TCC.Thalia.Teles.App.Paineis.Financeiros;
using TCC.Thalia.Teles.App.Paineis.Promocoes;
using TCC.Thalia.Teles.App.Paineis.Servicos;

namespace TCC.Thalia.Teles.App;

public partial class PrincipalTela : Form
{
    UserControl _controleDeUsuarioSelecionado;
    Button _botaoSelecionado;


    public PrincipalTela()
    {
        InitializeComponent();
        AoClicarEmUmBotao(new AtendimentosControleDeUsuario(), botaoAtendimentos);
    }

    void MudarBotao(Button botaoClicado)
    {
        if(_botaoSelecionado != null)
        {
            _botaoSelecionado.ForeColor = Color.White;
            _botaoSelecionado.BackColor = Color.Blue;
        }

        _botaoSelecionado = botaoClicado;
        _botaoSelecionado.BackColor = Color.DarkBlue;
    }
    void MudarPainelCentral(UserControl controleDeUsuario)
    {
        _controleDeUsuarioSelecionado = controleDeUsuario;
        _controleDeUsuarioSelecionado.Dock = DockStyle.Fill;
        painelCentral.Controls.Clear();
        painelCentral.Controls.Add(_controleDeUsuarioSelecionado);
    }
    void AoClicarEmUmBotao(UserControl controleDeUsuario, Button botaoClicado)
    {
        MudarPainelCentral(controleDeUsuario);
        MudarBotao(botaoClicado);
    }


    private void botaoAtendimentos_Click(object sender, EventArgs e)
    {
        AoClicarEmUmBotao(new AtendimentosControleDeUsuario(), botaoAtendimentos);
    }

    private void botaoServicos_Click(object sender, EventArgs e)
    {
        AoClicarEmUmBotao(new ServicosControleDeUsuario(), botaoServicos);
    }

    private void botaoPromocoes_Click(object sender, EventArgs e)
    {
        AoClicarEmUmBotao(new PromocoesControleDeUsuario(), botaoPromocoes);
    }

    private void botaoClientes_Click(object sender, EventArgs e)
    {
        AoClicarEmUmBotao(new ClientesControleDeUsuario(), botaoClientes);
    }

    private void botaoFinanceiro_Click(object sender, EventArgs e)
    {
        AoClicarEmUmBotao(new FinanceiroControleDeUsuario(), botaoFinanceiro);
    }
}