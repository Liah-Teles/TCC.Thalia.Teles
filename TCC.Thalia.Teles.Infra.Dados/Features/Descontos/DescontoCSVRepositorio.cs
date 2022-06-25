﻿using TCC.Thalia.Teles.Dominio.Features.Descontos;

namespace TCC.Thalia.Teles.Infra.Dados.Features.Descontos
{
    public class DescontoCSVRepositorio : ContratoDescontoRepositorio
    {
        private object _aguardarExecucao = new object();
        private string _localizacaoCsv;

        public DescontoCSVRepositorio(string localizacaoCsv)
        {
            _localizacaoCsv = $"{localizacaoCsv}\\Descontos.csv";
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
            lock (_aguardarExecucao)
            {
                var listaParaRetornar = new List<Desconto>();
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
        }

        public void Salvar(Desconto desconto)
        {
            var descontos = ObterTodos();

            if (descontos.Any(desc => desc.NomeServico == desconto.NomeServico))
            {
                if (descontos.Any(descontoExistente => (desconto.DataInicio >= descontoExistente.DataInicio && desconto.DataInicio <= descontoExistente.DataFinal)
                                                    || (desconto.DataFinal >= descontoExistente.DataInicio && desconto.DataFinal <= descontoExistente.DataFinal)))
                    throw new Exception($"A data informada ja existe desconto cadastrado no serviço: {desconto.NomeServico}");
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
                lock (_aguardarExecucao)
                {
                    var existeArquiv = File.Exists(_localizacaoCsv);

                    if (!existeArquiv)
                    {
                        var arquivo = File.Create(_localizacaoCsv);
                        arquivo.Close();
                    }

                    var linhasCsv = new List<string>();
                    linhasCsv.Add(Desconto.CabecalhoCsv);

                    foreach (var desconto in descontos)
                    {
                        linhasCsv.Add(desconto.ParaLinhaCsv());
                    }

                    File.WriteAllLines(_localizacaoCsv, linhasCsv);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar descontos", ex);
            }
        }
    }
}