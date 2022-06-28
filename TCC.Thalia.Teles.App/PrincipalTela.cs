using TCC.Thalia.Teles.App.Paineis.Agendamentos;
using TCC.Thalia.Teles.App.Paineis.Clientes;
using TCC.Thalia.Teles.App.Paineis.Financeiros;
using TCC.Thalia.Teles.App.Paineis.Descontos;
using TCC.Thalia.Teles.App.Paineis.Servicos;
using TCC.Thalia.Teles.Dominio.Features.Agendamentos;
using TCC.Thalia.Teles.Dominio.Features.Clientes;
using TCC.Thalia.Teles.Dominio.Features.Financeiros;
using TCC.Thalia.Teles.Dominio.Features.Descontos;
using TCC.Thalia.Teles.Dominio.Features.Servicos;
using TCC.Thalia.Teles.Infra.Dados.Features.Agendamentos;
using TCC.Thalia.Teles.Infra.Dados.Features.Clientes;
using TCC.Thalia.Teles.Infra.Dados.Features.Financeiros;
using TCC.Thalia.Teles.Infra.Dados.Features.Descontos;
using TCC.Thalia.Teles.Infra.Dados.Features.Servicos;

namespace TCC.Thalia.Teles.App;

public partial class PrincipalTela : Form
{
    private ContratoServicoRepositorio _contratoServicoRepositorio;
    private ContratoClienteRepositorio _contratoClienteRepositorio;
    private ContratoDescontoRepositorio _contratoDescontoRepositorio;
    private ContratoAgendamentoRepositorio _contratoAgendamentoRepositorio;
    private ContratoFinanceiroRepositorio _contratoFinanceiroRepositorio;

    private UserControl _controleDeUsuarioSelecionado;
    private Button _botaoSelecionado;
    private string _diretorioMeusDocumentos;
    private string _diretorioAgendamento;
    private string _localizacaoCsv;



    public PrincipalTela()
    {
        _diretorioMeusDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); ;
        _diretorioAgendamento = $"{_diretorioMeusDocumentos}\\Oasis Estetica\\Data\\Agendamentos";
        _localizacaoCsv = $"{_diretorioMeusDocumentos}\\Oasis Estetica\\Data";

        InitializeComponent();

        CriarEManipularDiretorio();

        _contratoServicoRepositorio = new ServicoCSVRepositorio(_localizacaoCsv);
        _contratoClienteRepositorio = new ClienteCSVRepositorio(_localizacaoCsv);
        _contratoDescontoRepositorio = new DescontoCSVRepositorio(_localizacaoCsv);
        _contratoAgendamentoRepositorio = new AgendamentoCSVRepositorio(_diretorioAgendamento);
        _contratoFinanceiroRepositorio = new FinanceiroCSVRepositorio(_localizacaoCsv);

        AoClicarEmUmBotao(new AgendamentosControleDeUsuario(_contratoAgendamentoRepositorio, _contratoServicoRepositorio, _contratoClienteRepositorio), botaoAgendamentos);
    }

    private void CriarEManipularDiretorio()
    {
        Directory.CreateDirectory(_diretorioAgendamento);
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
        if (botaoConcluirAgendamento == botaoClicado)
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
            botaoConcluirAgendamento.Visible = false;
        }

        MudarPainelCentral(controleDeUsuario);
        MudarBotao(botaoClicado);
    }


    private void botaoAgendamentos_Click(object sender, EventArgs e)
    {
        var agendamentosPainel = new AgendamentosControleDeUsuario(_contratoAgendamentoRepositorio, _contratoServicoRepositorio, _contratoClienteRepositorio);
        AoClicarEmUmBotao(agendamentosPainel, botaoAgendamentos);
    }

    private void botaoServicos_Click(object sender, EventArgs e)
    {
        AoClicarEmUmBotao(new ServicosControleDeUsuario(_contratoServicoRepositorio), botaoServicos);
    }

    private void botaoDescontos_Click(object sender, EventArgs e)
    {
        var promocoesPainel = new DescontosControleDeUsuario(_contratoDescontoRepositorio, _contratoServicoRepositorio);
        AoClicarEmUmBotao(promocoesPainel, botaoDescontos);
    }

    private void botaoClientes_Click(object sender, EventArgs e)
    {
        var clientePainel = new ClientesControleDeUsuario(_contratoClienteRepositorio, _contratoAgendamentoRepositorio);
        AoClicarEmUmBotao(clientePainel, botaoClientes);
    }

    private void botaoFinanceiro_Click(object sender, EventArgs e)
    {
        botaoConcluirAgendamento.Visible = true;

        var financeiroLista = new FinanceiroListaControleDeUsuario(_contratoFinanceiroRepositorio);

        AoClicarEmUmBotao(financeiroLista, botaoFinanceiro);
    }


    private void botaoConcluirAgendamento_Click(object sender, EventArgs e)
    {
        var agendamentos = _contratoAgendamentoRepositorio.ObterTodos(DateTime.Now).Where(agendamento => agendamento.Data.Day == DateTime.Now.Day).ToList();
        var promocoes = _contratoDescontoRepositorio.ObterTodos();

        var financeiroPainel = new FinanceiroControleDeUsuario(_contratoFinanceiroRepositorio, _contratoAgendamentoRepositorio, agendamentos, promocoes);

        AoClicarEmUmBotao(financeiroPainel, botaoConcluirAgendamento);
    }
}