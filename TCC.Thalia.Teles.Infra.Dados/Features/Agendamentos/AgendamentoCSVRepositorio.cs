using TCC.Thalia.Teles.Dominio.Features.Agendamentos;

namespace TCC.Thalia.Teles.Infra.Dados.Features.Agendamentos
{
    public class AgendamentoCSVRepositorio : ContratoAgendamentoRepositorio
    {
        private object _aguardarExecucao = new object();
        private string _localizacaoCsv;

        public AgendamentoCSVRepositorio(string localizacaoCsv)
        {
            _localizacaoCsv = localizacaoCsv;
        }

        public void Atualizar(Agendamento agendamento)
        {
            var agendamentos = ObterTodos(agendamento.Data);

            var csvAgendamento = agendamentos.FirstOrDefault(cli => cli.Id == agendamento.Id);

            if (csvAgendamento != null)
            {
                agendamentos.Remove(csvAgendamento);

                csvAgendamento.Cliente = agendamento.Cliente;
                csvAgendamento.Servicos = agendamento.Servicos;
                csvAgendamento.Concluido = agendamento.Concluido;
                csvAgendamento.Data = agendamento.Data;

                agendamentos.Add(csvAgendamento);

                SalvarTodos(agendamentos, agendamento.Data);
            }
        }

        public void DeletarPorCpfCliente(string cpfCliente)
        {
            var dataAtual = DateTime.Now;
            var dataMaisUmMes = dataAtual.AddMonths(1);
            var dataMaisDoisMeses = dataAtual.AddMonths(2);

            var agendamentoEsseMes = ObterTodos(dataAtual).Where(agendamento => agendamento.ClienteCpf == cpfCliente);
            var agendamento1MesFrente = ObterTodos(dataMaisUmMes).Where(agendamento => agendamento.ClienteCpf == cpfCliente);
            var agendamento2MesFrente = ObterTodos(dataMaisDoisMeses).Where(agendamento => agendamento.ClienteCpf == cpfCliente);


            if (agendamentoEsseMes != null)
            {
                foreach (var mes in agendamentoEsseMes)
                {
                    Deletar(mes.Id, dataAtual);
                }
            }

            if (agendamento1MesFrente != null)
            {
                foreach (var mes in agendamento1MesFrente)
                {
                    Deletar(mes.Id, dataMaisUmMes);
                }
            }

            if (agendamento2MesFrente != null)
            {
                foreach (var mes in agendamento2MesFrente)
                {
                    Deletar(mes.Id, dataMaisDoisMeses);
                }
            }
        }

        public void Deletar(int id, DateTime data)
        {
            var agendamentos = ObterTodos(data);

            var agendamento = agendamentos.FirstOrDefault(cli => cli.Id == id);

            if (agendamento != null)
            {
                agendamentos.Remove(agendamento);
                SalvarTodos(agendamentos, data);
            }
        }

        public Agendamento ObterPorId(int id, DateTime data)
        {
            var agendamentos = ObterTodos(data);

            return agendamentos.FirstOrDefault(agendamento => agendamento.Id == id);
        }

        public List<Agendamento> ObterTodos(DateTime data)
        {
            lock (_aguardarExecucao)
            {

                var listaParaRetornar = new List<Agendamento>();
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
                        var agendamento = new Agendamento();

                        if (agendamento.CriarPorLinhaCsv(linhasCsv[i]))
                        {
                            listaParaRetornar.Add(agendamento);
                        }
                    }


                    return listaParaRetornar.Where(agendamento => agendamento.Concluido == false)
                                            .OrderBy(agendamento => agendamento.Id)
                                            .ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro inesperado ao obter agendamentos", ex);
                }
            }
        }

        public void Salvar(Agendamento agendamento)
        {
            var agendamentos = ObterTodos(agendamento.Data);

            if (agendamentos.Any(csvAgendamento => csvAgendamento.Cliente == agendamento.Cliente &&
                                                   csvAgendamento.Data.Day == agendamento.Data.Day &&
                                                   csvAgendamento.Concluido == false))
            {
                throw new Exception("Já existe um agendamento para o cliente informado.");
            }

            var ultimoAgendamento = agendamentos.LastOrDefault();

            var ultimoId = 1;

            if (ultimoAgendamento != null)
            {
                ultimoId = ultimoAgendamento.Id + 1;
            }

            agendamento.Id = ultimoId;

            agendamentos.Add(agendamento);

            SalvarTodos(agendamentos, agendamento.Data);
        }
        private void SalvarTodos(List<Agendamento> agendamentos, DateTime data)
        {
            try
            {
                lock (_aguardarExecucao)
                {
                    var linhasCsv = new List<string>();
                    linhasCsv.Add(Agendamento.CabecalhoCsv);

                    foreach (var agendamento in agendamentos)
                    {
                        linhasCsv.Add(agendamento.ParaLinhaCsv());
                    }

                    var diretorioPorData = $"{_localizacaoCsv}\\{data.Year}\\{data.Month}\\Agenda.csv";

                    File.WriteAllLines(diretorioPorData, linhasCsv);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar agendamentos", ex);
            }
        }
    }
}
