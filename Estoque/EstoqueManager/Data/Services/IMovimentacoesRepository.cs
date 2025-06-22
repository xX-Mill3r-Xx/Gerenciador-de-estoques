using EstoqueManager.Models;
using System.Threading.Tasks;

namespace EstoqueManager.Data.Services
{
    public interface IMovimentacoesRepository
    {
        Task RegistrarMovimento(Movimentacoes movimento);
    }
}
