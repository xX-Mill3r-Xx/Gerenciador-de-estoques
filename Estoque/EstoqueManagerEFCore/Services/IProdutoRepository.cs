using EstoqueManagerEFCore.Models;

namespace EstoqueManagerEFCore.Services
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> ObterTodos();
        Task<IEnumerable<Produto>> ObterPorCategoria(int categoriaId);
        Task<Produto?> ObterPorId(int id);
        Task<Produto?> ObterPorNome(string nome);
        Task<Produto> Inserir(Produto entity);
        Task<Produto> Atualizar(Produto entity);
        Task<bool> Deletar(int id);
        Task<bool> PossuiMovimentacoes(int produtoId);
    }
}
