using TCC.Thalia.Teles.Dominio.Features.Atendimentos;

namespace TCC.Thalia.Teles.Infra.Dados.Features.Atendimentos
{
    public class AtendimentoCSVRepositorio : ContratoAtendimentoRepositorio
    {
        private object _aguardarExecucao = new object();
        private string _localizacaoCsv;

        public AtendimentoCSVRepositorio(string localizacaoCsv)
        {
            _localizacaoCsv = localizacaoCsv;
        }

        public void Atualizar(Atendimento atendimento)
        {
            var atendimentos = ObterTodos(atendimento.Data);

            var csvAtendimento = atendimentos.FirstOrDefault(cli => cli.Id == atendimento.Id);

            if (csvAtendimento != null)
            {
                atendimentos.Remove(csvAtendimento);

                csvAtendimento.Cliente = atendimento.Cliente;
                csvAtendimento.Servicos = atendimento.Servicos;
                csvAtendimento.Concluido = atendimento.Concluido;
                csvAtendimento.Data = atendimento.Data;

                atendimentos.Add(csvAtendimento);

                SalvarTodos(atendimentos, atendimento.Data);
            }
        }

        public void DeletarPorCpfCliente(string cpfCliente)
        {
            var dataAtual = DateTime.Now;
            var dataMaisUmMes = dataAtual.AddMonths(1);
            var dataMaisDoisMeses = dataAtual.AddMonths(2);

            var atendimentoEsseMes = ObterTodos(dataAtual).Where(atendimento => atendimento.ClienteCpf == cpfCliente);
            var atendimento1MesFrente = ObterTodos(dataMaisUmMes).Where(atendimento => atendimento.ClienteCpf == cpfCliente);
            var atendimento2MesFrente = ObterTodos(dataMaisDoisMeses).Where(atendimento => atendimento.ClienteCpf == cpfCliente);


            if (atendimentoEsseMes != null)
            {
                foreach (var mes in atendimentoEsseMes)
                {
                    Deletar(mes.Id, dataAtual);
                }
            }

            if (atendimento1MesFrente != null)
            {
                foreach (var mes in atendimento1MesFrente)
                {
                    Deletar(mes.Id, dataMaisUmMes);
                }
            }

            if (atendimento2MesFrente != null)
            {
                foreach (var mes in atendimento2MesFrente)
                {
                    Deletar(mes.Id, dataMaisDoisMeses);
                }
            }
        }

        public void Deletar(int id, DateTime data)
        {
            var atendimentos = ObterTodos(data);

            var atendimento = atendimentos.FirstOrDefault(cli => cli.Id == id);

            if (atendimento != null)
            {
                atendimentos.Remove(atendimento);
                SalvarTodos(atendimentos, data);
            }
        }

        public Atendimento ObterPorId(int id, DateTime data)
        {
            var atendimentos = ObterTodos(data);

            return atendimentos.FirstOrDefault(atendimento => atendimento.Id == id);
        }

        public List<Atendimento> ObterTodos(DateTime data)
        {
            lock (_aguardarExecucao)
            {

                var listaParaRetornar = new List<Atendimento>();
                try
                {
                    var diretorioPorData = $"{_localizacaoCsv}\\{data.Year}\\{data.Month}";

                    Directory.CreateDirectory(diretorioPorData);

                    var caminhoArquivo = $"{diretorioPorData}\\Agenda.csv";

                    var existeArquivo = File.Exists(caminhoArquivo);

                    if (!existeArquivo)
                    {
                        var arquivo = File.Create(caminhoArquivo);
                        arquivo.Close();
                        return listaParaRetornar;
                    }

                    var linhasCsv = File.ReadAllLines(caminhoArquivo);

                    for (int i = 1; i < linhasCsv.Length; i++)
                    {
                        var atendimento = new Atendimento();

                        if (atendimento.CriarPorLinhaCsv(linhasCsv[i]))
                        {
                            listaParaRetornar.Add(atendimento);
                        }
                    }


                    return listaParaRetornar.Where(atendimento => atendimento.Concluido == false)
                                            .OrderBy(atendimento => atendimento.Id)
                                            .ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro inesperado ao obter atendimentos", ex);
                }
            }
        }

        public void Salvar(Atendimento atendimento)
        {
            var atendimentos = ObterTodos(atendimento.Data);

            if (atendimentos.Any(csvAtendimento => csvAtendimento.Cliente == atendimento.Cliente &&
                                                   csvAtendimento.Data.Day == atendimento.Data.Day &&
                                                   csvAtendimento.Concluido == false))
            {
                throw new Exception("Já existe um atendimento para o cliente informado.");
            }

            var ultimoAtendimento = atendimentos.LastOrDefault();

            var ultimoId = 1;

            if (ultimoAtendimento != null)
            {
                ultimoId = ultimoAtendimento.Id + 1;
            }

            atendimento.Id = ultimoId;

            atendimentos.Add(atendimento);

            SalvarTodos(atendimentos, atendimento.Data);
        }
        private void SalvarTodos(List<Atendimento> atendimentos, DateTime data)
        {
            try
            {
                lock (_aguardarExecucao)
                {
                    var linhasCsv = new List<string>();
                    linhasCsv.Add(Atendimento.CabecalhoCsv);

                    foreach (var atendimento in atendimentos)
                    {
                        linhasCsv.Add(atendimento.ParaLinhaCsv());
                    }

                    var diretorioPorData = $"{_localizacaoCsv}\\{data.Year}\\{data.Month}\\Agenda.csv";

                    File.WriteAllLines(diretorioPorData, linhasCsv);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar atendimentos", ex);
            }
        }
    }
}
