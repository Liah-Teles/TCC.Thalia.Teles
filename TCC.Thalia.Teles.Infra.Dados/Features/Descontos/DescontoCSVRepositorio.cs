using TCC.Thalia.Teles.Dominio.Features.Descontos;

namespace TCC.Thalia.Teles.Infra.Dados.Features.Descontos
{
    public class DescontoCSVRepositorio : ContratoDescontoRepositorio
    {
        private string _localizacaoArquivoCsv;
        private string _diretorio;

        public DescontoCSVRepositorio(string diretorioParaOArquivo)
        {
            _diretorio = diretorioParaOArquivo;
            _localizacaoArquivoCsv = $"{diretorioParaOArquivo}\\Descontos.csv";
        }

        public void Atualizar(Desconto desconto)
        {
            var descontos = ObterTodos();

            var csvDesconto = descontos.FirstOrDefault(cli => cli.Id == desconto.Id);

            if (csvDesconto != null)
            {
                descontos.Remove(csvDesconto);

                csvDesconto.NomeServico = desconto.NomeServico;
                csvDesconto.Valor = desconto.Valor;

                descontos.Add(csvDesconto);

                SalvarTodos(descontos);
            }
        }

        public void Deletar(int id)
        {
            var descontos = ObterTodos();

            var desconto = descontos.FirstOrDefault(cli => cli.Id == id);

            if (desconto != null)
            {
                descontos.Remove(desconto);
                SalvarTodos(descontos);
            }
        }

        public Desconto ObterPorId(int id)
        {
            var descontos = ObterTodos();

            return descontos.FirstOrDefault(desconto => desconto.Id == id);
        }

        public List<Desconto> ObterTodos()
        {
            Directory.CreateDirectory(_diretorio);

            var listaParaRetornar = new List<Desconto>();
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
                    var desconto = new Desconto();

                    if (desconto.CriarPorLinhaCsv(linhasCsv[i]))
                    {
                        listaParaRetornar.Add(desconto);
                    }
                }


                return listaParaRetornar.OrderBy(desconto => desconto.Id).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro inesperado ao obter descontos", ex);
            }
        }

        public void Salvar(Desconto desconto)
        {
            var descontos = ObterTodos();

            if (descontos.Any(desc => desc.NomeServico == desconto.NomeServico))
            {
                if (descontos.Any(descontoExistente => (desconto.DataInicio >= descontoExistente.DataInicio && desconto.DataInicio <= descontoExistente.DataFinal)
                                                    || (desconto.DataFinal >= descontoExistente.DataInicio && desconto.DataFinal <= descontoExistente.DataFinal)))
                    throw new Exception($"A data informada já possui desconto cadastrado no serviço: {desconto.NomeServico}");
            }

            var ultimoDesconto = descontos.LastOrDefault();

            var ultimoId = 1;

            if (ultimoDesconto != null)
            {
                ultimoId = ultimoDesconto.Id + 1;
            }

            desconto.Id = ultimoId;

            descontos.Add(desconto);

            SalvarTodos(descontos);
        }
        private void SalvarTodos(List<Desconto> descontos)
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
                linhasCsv.Add(Desconto.CabecalhoCsv);

                foreach (var desconto in descontos)
                {
                    linhasCsv.Add(desconto.ParaLinhaCsv());
                }

                File.WriteAllLines(_localizacaoArquivoCsv, linhasCsv);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar descontos", ex);
            }
        }
    }
}
