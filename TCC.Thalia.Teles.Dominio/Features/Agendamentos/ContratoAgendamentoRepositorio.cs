namespace TCC.Thalia.Teles.Dominio.Features.Agendamentos
{
    public interface ContratoAgendamentoRepositorio
    {
        List<Agendamento> ObterTodos(DateTime data);
        Agendamento ObterPorId(int id, DateTime data);
        void DeletarPorCpfCliente(string cpfCliente);
        void Salvar(Agendamento cliente);
        void Atualizar(Agendamento cliente);
        void Deletar(int id, DateTime data);
    }
}
