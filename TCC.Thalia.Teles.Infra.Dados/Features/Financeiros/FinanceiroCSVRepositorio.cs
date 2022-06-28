using TCC.Thalia.Teles.Dominio.Features.Financeiros;

namespace TCC.Thalia.Teles.Infra.Dados.Features.Financeiros
{
    public class FinanceiroCSVRepositorio : ContratoFinanceiroRepositorio
    {
        private string _localizacaoArquivoCsv;
        private string _diretorio;

        public FinanceiroCSVRepositorio(string diretorioParaOArquivo)
        {
            _diretorio = diretorioParaOArquivo;
            _localizacaoArquivoCsv = $"{diretorioParaOArquivo}\\Financeiro.csv";
        }

        public void Atualizar(Financeiro financeiro)
        {
            var financeiros = ObterTodos();

            var csvFinanceiro = financeiros.FirstOrDefault(cli => cli.Id == financeiro.Id);

            if (csvFinanceiro != null)
            {
                financeiros.Remove(csvFinanceiro);

                csvFinanceiro.Total = financeiro.Total;
                csvFinanceiro.ValorParcial = financeiro.ValorParcial;
                csvFinanceiro.DescontoAplicado = financeiro.DescontoAplicado;
                csvFinanceiro.Agendamento = financeiro.Agendamento;
                csvFinanceiro.Descontos = financeiro.Descontos;

                financeiros.Add(csvFinanceiro);

                SalvarTodos(financeiros);
            }
        }

        public void Deletar(int id)
        {
            var financeiros = ObterTodos();

            var financeiro = financeiros.FirstOrDefault(cli => cli.Id == id);

            if (financeiro != null)
            {
                financeiros.Remove(financeiro);
                SalvarTodos(financeiros);
            }
        }

        public Financeiro ObterPorId(int id)
        {
            var financeiros = ObterTodos();

            return financeiros.FirstOrDefault(financeiro => financeiro.Id == id);
        }

        public List<Financeiro> ObterTodos()
        {
            Directory.CreateDirectory(_diretorio);
            var listaParaRetornar = new List<Financeiro>();
            try
            {
                var existeArquivo = File.Exists(_localizacaoArquivoCsv);

                if (!existeArquivo)
                {
                    var arquivo = File.Create(_localizacaoArquivoCsv);
                    arquivo.Close();
                    return listaParaRetornar;
                }

                var linhasCsv = File.ReadAllLines(_localizacaoArquivoCsv);

                for (int i = 1; i < linhasCsv.Length; i++)
                {
                    var financeiro = new Financeiro();

                    if (financeiro.CriarPorLinhaCsv(linhasCsv[i]))
                    {
                        listaParaRetornar.Add(financeiro);
                    }
                }


                return listaParaRetornar.OrderBy(financeiro => financeiro.Id).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro inesperado ao obter financeiros", ex);
            }
        }
        public List<Financeiro> ObterTodosConcluidosNoAno(int ano)
        {
            var todos = ObterTodos();
            var todosDoAno = todos.Where(financeiro => financeiro.Agendamento.Data.Year == ano);
            var concluidos = todosDoAno.Where(financeiro => financeiro.Agendamento.Concluido);

            return concluidos.ToList();
        }

        public void Salvar(Financeiro financeiro)
        {
            var financeiros = ObterTodos();

            var ultimoFinanceiro = financeiros.LastOrDefault();

            var ultimoId = 1;

            if (ultimoFinanceiro != null)
            {
                ultimoId = ultimoFinanceiro.Id + 1;
            }

            financeiro.Id = ultimoId;

            financeiros.Add(financeiro);

            SalvarTodos(financeiros);
        }
        private void SalvarTodos(List<Financeiro> financeiros)
        {
            try
            {
                var existeArquiv = File.Exists(_localizacaoArquivoCsv);

                if (!existeArquiv)
                {
                    var arquivo = File.Create(_localizacaoArquivoCsv);
                    arquivo.Close();
                }

                var linhasCsv = new List<string>();
                linhasCsv.Add(Financeiro.CabecalhoCsv);

                foreach (var financeiro in financeiros)
                {
                    linhasCsv.Add(financeiro.ParaLinhaCsv());
                }

                File.WriteAllLines(_localizacaoArquivoCsv, linhasCsv);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao realizar o fechamento do agendamento", ex);
            }
        }
    }
}
