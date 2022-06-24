namespace TCC.Thalia.Teles.Dominio.Features.Promocoes
{
    public interface ContratoPromocaoRepositorio
    {
        List<Promocao> ObterTodos();
        Promocao ObterPorId(int id);
        void Salvar(Promocao cliente);
        void Atualizar(Promocao cliente);
        void Deletar(int id);
    }
}
