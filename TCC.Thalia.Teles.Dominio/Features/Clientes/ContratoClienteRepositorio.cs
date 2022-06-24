namespace TCC.Thalia.Teles.Dominio.Features.Clientes
{
    public interface ContratoClienteRepositorio
    {
        List<Cliente> ObterTodos();
        Cliente ObterPorId(int id);
        void Salvar(Cliente cliente);
        void Atualizar(Cliente cliente);
        void Deletar(int id);
    }
}
