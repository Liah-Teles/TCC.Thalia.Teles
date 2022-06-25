namespace TCC.Thalia.Teles.Dominio.Features.Atendimentos
{
    public interface ContratoAtendimentoRepositorio
    {
        List<Atendimento> ObterTodos(DateTime data);
        Atendimento ObterPorId(int id, DateTime data);
        void DeletarPorCpfCliente(string cpfCliente);
        void Salvar(Atendimento cliente);
        void Atualizar(Atendimento cliente);
        void Deletar(int id, DateTime data);
    }
}
