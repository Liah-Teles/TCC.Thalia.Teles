namespace TCC.Thalia.Teles.Dominio.Features.Financeiros
{
    public interface ContratoFinanceiroRepositorio
    {
        List<Financeiro> ObterTodos();
        List<Financeiro> ObterTodosConcluidosNoAno(int ano);
        Financeiro ObterPorId(int id);
        void Salvar(Financeiro financeiro);
        void Atualizar(Financeiro financeiro);
        void Deletar(int id);
    }
}
