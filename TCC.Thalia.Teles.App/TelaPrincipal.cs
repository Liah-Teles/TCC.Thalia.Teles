using TCC.Thalia.Teles.App.Paineis.Atendimentos;
using TCC.Thalia.Teles.App.Paineis.Clientes;
using TCC.Thalia.Teles.App.Paineis.Financeiros;
using TCC.Thalia.Teles.App.Paineis.Promocoes;
using TCC.Thalia.Teles.App.Paineis.Servicos;
using TCC.Thalia.Teles.Dominio.Features.Atendimentos;
using TCC.Thalia.Teles.Dominio.Features.Clientes;
using TCC.Thalia.Teles.Dominio.Features.Financeiros;
using TCC.Thalia.Teles.Dominio.Features.Promocoes;
using TCC.Thalia.Teles.Dominio.Features.Servicos;
using TCC.Thalia.Teles.Infra.Dados.Features.Atendimentos;
using TCC.Thalia.Teles.Infra.Dados.Features.Clientes;
using TCC.Thalia.Teles.Infra.Dados.Features.Financeiros;
using TCC.Thalia.Teles.Infra.Dados.Features.Promocoes;
using TCC.Thalia.Teles.Infra.Dados.Features.Servicos;

namespace TCC.Thalia.Teles.App;

public partial class PrincipalTela : Form
{
    private ContratoServicoRepositorio _contratoServicoRepositorio;
    private ContratoClienteRepositorio _contratoClienteRepositorio;
    private ContratoPromocaoRepositorio _contratoPromocaoRepositorio;
    private ContratoAtendimentoRepositorio _contratoAtendimentoRepositorio;
    private ContratoFinanceiroRepositorio _contratoFinanceiroRepositorio;

    private UserControl _controleDeUsuarioSelecionado;
    private Button _botaoSelecionado;
    private string _diretorioAtendimento = $"{Directory.GetCurrentDirectory()}\\Data\\Atendimentos";

    private string _localizacaoCsv = $"{Directory.GetCurrentDirectory()}\\Data";



    public PrincipalTela()
    {
        InitializeComponent();

        CriarEManipularDiretorio();

        _contratoServicoRepositorio = new ServicoCSVRepositorio(_localizacaoCsv);
        _contratoClienteRepositorio = new ClienteCSVRepositorio(_localizacaoCsv);
        _contratoPromocaoRepositorio = new PromocaoCSVRepositorio(_localizacaoCsv);
        _contratoAtendimentoRepositorio = new AtendimentoCSVRepositorio(_diretorioAtendimento);
        _contratoFinanceiroRepositorio = new FinanceiroCSVRepositorio(_localizacaoCsv);

        AoClicarEmUmBotao(new AtendimentosControleDeUsuario(_contratoAtendimentoRepositorio, _contratoServicoRepositorio, _contratoClienteRepositorio), botaoAtendimentos);
    }

    private void CriarEManipularDiretorio()
    {
        Directory.CreateDirectory(_diretorioAtendimento);
        DirectoryInfo informacoesDiretorio = new DirectoryInfo(_localizacaoCsv);
        informacoesDiretorio.Attributes = FileAttributes.Normal;
    }

    protected override void OnClosed(EventArgs e)
    {
        DirectoryInfo informacoesDiretorio = new DirectoryInfo(_localizacaoCsv);
        informacoesDiretorio.Attributes = FileAttributes.Hidden;
        base.OnClosed(e);
    }

    void MudarBotao(Button botaoClicado)
    {
        if(botaoConcluirAtendimento == botaoClicado)
        {
            return;
        }

        if (_botaoSelecionado != null)
        {
            _botaoSelecionado.ForeColor = Color.White;
            _botaoSelecionado.BackColor = Color.Blue;
        }

        _botaoSelecionado = botaoClicado;
        _botaoSelecionado.BackColor = Color.RoyalBlue;
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
        if (botaoClicado != botaoFinanceiro)
        {
            botaoConcluirAtendimento.Visible = false;
        }

        MudarPainelCentral(controleDeUsuario);
        MudarBotao(botaoClicado);
    }


    private void botaoAtendimentos_Click(object sender, EventArgs e)
    {
        var atendimentosPainel = new AtendimentosControleDeUsuario(_contratoAtendimentoRepositorio, _contratoServicoRepositorio, _contratoClienteRepositorio);
        AoClicarEmUmBotao(atendimentosPainel, botaoAtendimentos);
    }

    private void botaoServicos_Click(object sender, EventArgs e)
    {
        AoClicarEmUmBotao(new ServicosControleDeUsuario(_contratoServicoRepositorio), botaoServicos);
    }

    private void botaoPromocoes_Click(object sender, EventArgs e)
    {
        var promocoesPainel = new PromocoesControleDeUsuario(_contratoPromocaoRepositorio, _contratoServicoRepositorio);
        AoClicarEmUmBotao(promocoesPainel, botaoPromocoes);
    }

    private void botaoClientes_Click(object sender, EventArgs e)
    {
        var clientePainel = new ClientesControleDeUsuario(_contratoClienteRepositorio);
        AoClicarEmUmBotao(clientePainel, botaoClientes);
    }

    private void botaoFinanceiro_Click(object sender, EventArgs e)
    {
        botaoConcluirAtendimento.Visible = true;

        var financeiroLista = new FinanceiroListaControleDeUsuario(_contratoFinanceiroRepositorio);
        
        AoClicarEmUmBotao(financeiroLista, botaoFinanceiro);
    }


    private void botaoConcluirAtendimento_Click(object sender, EventArgs e)
    {
        var atendimentos = _contratoAtendimentoRepositorio.ObterTodos(DateTime.Now).Where(atendimento => atendimento.Data.Day == DateTime.Now.Day).ToList();
        var promocoes = _contratoPromocaoRepositorio.ObterTodos();

        var financeiroPainel = new FinanceiroControleDeUsuario(_contratoFinanceiroRepositorio, _contratoAtendimentoRepositorio, atendimentos, promocoes);

        AoClicarEmUmBotao(financeiroPainel, botaoConcluirAtendimento);
    }
}