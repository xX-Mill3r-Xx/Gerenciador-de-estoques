using EstoqueManagerEFCore.Data;
using EstoqueManagerEFCore.Models;
using EstoqueManagerEFCore.Repositories;

namespace EstoqueManagerEFCore.Controllers
{
    public class ProdutoController
    {
        #region Properties

        private readonly ProdutoRepository _produtoRepository;

        #endregion

        #region Constructors

        public ProdutoController()
        {
            var context = new EstoqueManagerContext();
            _produtoRepository = new ProdutoRepository(context);
        }

        #endregion

        public async Task<IEnumerable<Produto>> ObterProdutos() =>
            await _produtoRepository.ObterTodos();

        public async Task<IEnumerable<Produto>> ObterPorCategoria(int categoriaId) =>
            await _produtoRepository.ObterPorCategoria(categoriaId);

        public async Task<Produto?> ObterPorId(int id) =>
            await _produtoRepository.ObterPorId(id);

        public async Task<Produto?> ObterPorNome(string nome) =>
            await _produtoRepository.ObterPorNome(nome);

        public async Task SalvarProduto(Produto produto) =>
            await _produtoRepository.Inserir(produto);

        public async Task<Produto> AtualizarProduto(Produto produto) =>
            await _produtoRepository.Atualizar(produto);

        public async Task<bool> DeletarProduto(int id) =>
            await _produtoRepository.Deletar(id);

        public async Task<bool> ProdutoPossuiMovimentacoes(int produtoId) =>
            await _produtoRepository.PossuiMovimentacoes(produtoId);
    }
}
