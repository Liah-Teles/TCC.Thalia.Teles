using TCC.Thalia.Teles.Dominio.Features.Clientes;
using TCC.Thalia.Teles.Dominio.Features.Promocoes;
using TCC.Thalia.Teles.Dominio.Features.Servicos;

namespace TCC.Thalia.Teles.App.Paineis.Promocoes
{
    public partial class AdicionarPromocoesTela : Form
    {
        private Promocao _promocao;
        private List<Servico> _servicos;

        public AdicionarPromocoesTela(List<Servico> servicos)
        {
            InitializeComponent();
            _servicos = servicos;
            listaNomesServicos.DataSource = _servicos;
            listaNomesServicos.DisplayMember = nameof(Servico.Nome);
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            var servicoSelecionado = listaNomesServicos.SelectedItem as Servico;

            if(servicoSelecionado == null)
            {
                MessageBox.Show("Selecione um serviço", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(caixaNumericaValor.Value >= servicoSelecionado.Valor)
            {
                MessageBox.Show("Desconto não pode possuir valor maior que o serviço.", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _promocao = new Promocao
            {
                Desconto = caixaNumericaValor.Value,
                NomeServico = servicoSelecionado.Nome
            };

            var mensagem = _promocao.ObterMensagemNaoValidado();

            if (string.IsNullOrEmpty(mensagem))
            {
                DialogResult = DialogResult.Yes;
                return;
            }

            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public Promocao ObterPromocao()
        {
            return _promocao;
        }
    }
}
