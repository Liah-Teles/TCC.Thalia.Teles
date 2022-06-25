namespace TCC.Thalia.Teles.Dominio.Features.Descontos
{
    public interface ContratoDescontoRepositorio
    {
        List<Desconto> ObterTodos();
        Desconto ObterPorId(int id);
        void Salvar(Desconto cliente);
        void Atualizar(Desconto cliente);
        void Deletar(int id);
    }
}
