using EstoqueManager.Data;
using EstoqueManager.Data.Repositories;
using EstoqueManager.Models;
using System.Threading.Tasks;

namespace EstoqueManager.Controller
{
    public class ProdutoController
    {
        #region Properties

        private ProdutoRepository _produtoRepository;

        #endregion

        #region Constructors

        public ProdutoController()
        {
            _produtoRepository = new ProdutoRepository(StringConnection.Conexao());
        }

        #endregion

        public async Task SalvarProduto(Produto produto)
        {
            await _produtoRepository.Inserir(produto);
        }
    }
}
