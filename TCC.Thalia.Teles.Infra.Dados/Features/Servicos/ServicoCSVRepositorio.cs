using TCC.Thalia.Teles.Dominio.Features.Servicos;

namespace TCC.Thalia.Teles.Infra.Dados.Features.Servicos
{
    public class ServicoCSVRepositorio : ContratoServicoRepositorio
    {
        private object _aguardarExecucao = new object();
        private string _localizacaoCsv;

        public ServicoCSVRepositorio(string localizacaoCsv)
        {
            _localizacaoCsv = $"{localizacaoCsv}\\Servicos.csv";
        }

        public void Atualizar(Servico servico)
        {
            var servicos = ObterTodos();

            var csvServico = servicos.FirstOrDefault(cli => cli.Id == servico.Id);

            if (csvServico != null)
            {
                servicos.Remove(csvServico);

                csvServico.Nome = servico.Nome;
                csvServico.Valor = servico.Valor;

                servicos.Add(csvServico);

                SalvarServicos(servicos);
            }
        }

        public void Deletar(int id)
        {
            var servicos = ObterTodos();

            var servico = servicos.FirstOrDefault(cli => cli.Id == id);

            if (servico != null)
            {
                servicos.Remove(servico);
                SalvarServicos(servicos);
            }
        }

        public Servico ObterPorId(int id)
        {
            var servicos = ObterTodos();

            return servicos.FirstOrDefault(servico => servico.Id == id);
        }

        public List<Servico> ObterTodos()
        {
            lock (_aguardarExecucao)
            {
                var listaParaRetornar = new List<Servico>();
                try
                {
                    var existeArquiv = File.Exists(_localizacaoCsv);

                    if (!existeArquiv)
                    {
                        var arquivo = File.Create(_localizacaoCsv);
                        arquivo.Close();
                        return listaParaRetornar;
                    }

                    var linhasCsv = File.ReadAllLines(_localizacaoCsv);

                    for (int i = 1; i < linhasCsv.Length; i++)
                    {
                        var servico = new Servico();

                        if (servico.CriarPorLinhaCsv(linhasCsv[i]))
                        {
                            listaParaRetornar.Add(servico);
                        }
                    }


                    return listaParaRetornar.OrderBy(service => service.Id).ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro inesperado ao obter servicos", ex);
                }
            }
        }

        public void Salvar(Servico servico)
        {
            var servicos = ObterTodos();

            if (servicos.Any(cli => cli.Nome == servico.Nome))
            {
                throw new Exception("Já existe um usuario com o documento informado");
            }

            var ultimoServico = servicos.LastOrDefault();

            var ultimoId = 1;

            if (ultimoServico != null)
            {
                ultimoId = ultimoServico.Id + 1;
            }

            servico.Id = ultimoId;

            servicos.Add(servico);

            SalvarServicos(servicos);
        }
        private void SalvarServicos(List<Servico> servicos)
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
                    linhasCsv.Add(Servico.CabecalhoCsv);

                    foreach (var servico in servicos)
                    {
                        linhasCsv.Add(servico.ParaLinhaCsv());
                    }

                    File.WriteAllLines(_localizacaoCsv, linhasCsv);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar servicos", ex);
            }
        }
    }
}
