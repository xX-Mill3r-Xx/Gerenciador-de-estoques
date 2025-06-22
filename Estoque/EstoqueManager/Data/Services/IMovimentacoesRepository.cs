using EstoqueManager.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstoqueManager.Data.Services
{
    public interface IMovimentacoesRepository
    {
        Task RegistrarMovimento(Movimentacoes movimento);
        Task<IEnumerable<Movimentacoes>> ObterPorProduto(int produtoId);
    }
}
