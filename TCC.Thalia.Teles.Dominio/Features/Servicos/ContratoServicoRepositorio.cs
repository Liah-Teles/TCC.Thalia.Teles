namespace TCC.Thalia.Teles.Dominio.Features.Servicos
{
    public interface ContratoServicoRepositorio
    {
        List<Servico> ObterTodos();
        Servico ObterPorId(int id);
        void Salvar(Servico cliente);
        void Atualizar(Servico cliente);
        void Deletar(int id);
    }
}
