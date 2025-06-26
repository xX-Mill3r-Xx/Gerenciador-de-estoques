using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstoqueManager.Data.Services
{
    public interface IProdutoRepository<T>
    {
        Task<IEnumerable<T>> ObterTodos();
        Task<IEnumerable<T>> ObterPorCategoria(int categoriaId);
        Task<T> ObterPorId(int id);
        Task<T> ObterPorNome(string nome);
        Task<T> Inserir(T entity);
        Task<T> Atualizar(T entity);
        Task<T> Deletar(int id);
        Task<bool> PossuiMovimentacoes(int produtoId);
    }
}
