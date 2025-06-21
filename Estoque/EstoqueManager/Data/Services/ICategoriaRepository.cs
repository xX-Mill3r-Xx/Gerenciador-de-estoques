using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstoqueManager.Data.Services
{
    public interface ICategoriaRepository<T>
    {
        Task<IEnumerable<T>> ObterTodos();
        Task<T> ObterPorId(int id);
        Task<T> ObterPorNome(string nome);
        Task<T> Inserir(T entity);
        Task<T> Atualizar(T entity);
        Task<T> Deletar(int id);
    }
}
