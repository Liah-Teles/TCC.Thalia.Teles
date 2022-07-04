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

            if (VerificaSeEstaTudoValido(servicoSelecionado) == true)
            {
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
                }
                else
                {
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool VerificaSeEstaTudoValido(Servico servicoSelecionado)
        {
            if (servicoSelecionado == null)
            {
                MessageBox.Show("Selecione um serviço", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (caixaNumericaValor.Value >= servicoSelecionado.Valor)
            {
                MessageBox.Show("Desconto não pode possuir valor maior que o serviço.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (caixaDataInicio.Value.Date >= caixaDataFinal.Value.Date)
            {
                MessageBox.Show("Data de início não pode ser maior ou igual a data final.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (caixaDataInicio.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Data de início inválida, deve ser maior que data de hoje.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public Desconto ObterDesconto()
        {
            return _desconto;
        }
    }
}
