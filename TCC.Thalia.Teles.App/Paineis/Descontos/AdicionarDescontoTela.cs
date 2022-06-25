using TCC.Thalia.Teles.Dominio.Features.Descontos;
using TCC.Thalia.Teles.Dominio.Features.Servicos;

namespace TCC.Thalia.Teles.App.Paineis.Descontos
{
    public partial class AdicionarDescontoTela : Form
    {
        private Desconto _desconto;
        private List<Servico> _servicos;

        public AdicionarDescontoTela(List<Servico> servicos)
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

            if (caixaDataInicio.Value.Date >= caixaDataFinal.Value.Date)
            {
                MessageBox.Show("Data de inicio não pode ser maior ou igual a data final.", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (caixaDataInicio.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Data de inicio invalida, deve ser maior que data de hoje.", "Atênção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _desconto = new Desconto
            {
                Valor = caixaNumericaValor.Value + 0.00M,
                NomeServico = servicoSelecionado.Nome,
                DataInicio = caixaDataInicio.Value.Date,
                DataFinal = caixaDataFinal.Value.Date,
            };

            var mensagem = _desconto.ObterMensagemNaoValidado();

            if (string.IsNullOrEmpty(mensagem))
            {
                DialogResult = DialogResult.Yes;
                return;
            }

            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public Desconto ObterDesconto()
        {
            return _desconto;
        }
    }
}
