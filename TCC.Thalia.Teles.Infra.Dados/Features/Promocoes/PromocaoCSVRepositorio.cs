using TCC.Thalia.Teles.Dominio.Features.Promocoes;

namespace TCC.Thalia.Teles.Infra.Dados.Features.Promocoes
{
    public class PromocaoCSVRepositorio : ContratoPromocaoRepositorio
    {
        private object _aguardarExecucao = new object();
        private string _localizacaoCsv;

        public PromocaoCSVRepositorio(string localizacaoCsv)
        {
            _localizacaoCsv = $"{localizacaoCsv}\\Promocoes.csv";
        }

        public void Atualizar(Promocao promocao)
        {
            var promocaos = ObterTodos();

            var csvPromocao = promocaos.FirstOrDefault(cli => cli.Id == promocao.Id);

            if (csvPromocao != null)
            {
                promocaos.Remove(csvPromocao);

                csvPromocao.NomeServico = promocao.NomeServico;
                csvPromocao.Desconto = promocao.Desconto;

                promocaos.Add(csvPromocao);

                SalvarTodos(promocaos);
            }
        }

        public void Deletar(int id)
        {
            var promocaos = ObterTodos();

            var promocao = promocaos.FirstOrDefault(cli => cli.Id == id);

            if (promocao != null)
            {
                promocaos.Remove(promocao);
                SalvarTodos(promocaos);
            }
        }

        public Promocao ObterPorId(int id)
        {
            var promocaos = ObterTodos();

            return promocaos.FirstOrDefault(promocao => promocao.Id == id);
        }

        public List<Promocao> ObterTodos()
        {
            lock (_aguardarExecucao)
            {
                var listaParaRetornar = new List<Promocao>();
                try
                {
                    var existeArquivo = File.Exists(_localizacaoCsv);

                    if (!existeArquivo)
                    {
                        var arquivo = File.Create(_localizacaoCsv);
                        arquivo.Close();
                        return listaParaRetornar;
                    }

                    var linhasCsv = File.ReadAllLines(_localizacaoCsv);

                    for (int i = 1; i < linhasCsv.Length; i++)
                    {
                        var promocao = new Promocao();

                        if (promocao.CriarPorLinhaCsv(linhasCsv[i]))
                        {
                            listaParaRetornar.Add(promocao);
                        }
                    }


                    return listaParaRetornar.OrderBy(promocao => promocao.Id).ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro inesperado ao obter promocaos", ex);
                }
            }
        }

        public void Salvar(Promocao promocao)
        {
            var promocaos = ObterTodos();

            if (promocaos.Any(cli => cli.NomeServico == promocao.NomeServico))
            {
                throw new Exception("Já existe uma promoção para o serviço informado.");
            }

            var ultimoPromocao = promocaos.LastOrDefault();

            var ultimoId = 1;

            if (ultimoPromocao != null)
            {
                ultimoId = ultimoPromocao.Id + 1;
            }

            promocao.Id = ultimoId;

            promocaos.Add(promocao);

            SalvarTodos(promocaos);
        }
        private void SalvarTodos(List<Promocao> promocaos)
        {
            try
            {
                lock (_aguardarExecucao)
                {
                    var existeArquiv = File.Exists(_localizacaoCsv);

                    if (!existeArquiv)
                    {
                        var arquivo = File.Create(_localizacaoCsv);
                        arquivo.Close();
                    }

                    var linhasCsv = new List<string>();
                    linhasCsv.Add(Promocao.CabecalhoCsv);

                    foreach (var promocao in promocaos)
                    {
                        linhasCsv.Add(promocao.ParaLinhaCsv());
                    }

                    File.WriteAllLines(_localizacaoCsv, linhasCsv);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar promocaos", ex);
            }
        }
    }
}
