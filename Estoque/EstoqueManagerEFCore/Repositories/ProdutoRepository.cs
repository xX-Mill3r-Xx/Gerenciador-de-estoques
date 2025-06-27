using EstoqueManagerEFCore.Data;
using EstoqueManagerEFCore.Models;
using EstoqueManagerEFCore.Services;
using Microsoft.EntityFrameworkCore;

namespace EstoqueManagerEFCore.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        #region Properties

        private readonly EstoqueManagerContext _context;

        #endregion

        #region Constructors

        public ProdutoRepository(EstoqueManagerContext context)
        {
            _context = context;
        }

        #endregion

        public async Task<IEnumerable<Produto>> ObterTodos()
        {
            try
            {
                return await _context.Produtos.Include(p => p.Categoria)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao obter lista de produtos. {ex.Message}");
            }
        }

        public async Task<IEnumerable<Produto>> ObterPorCategoria(int categoriaId)
        {
            try
            {
                return await _context.Produtos.Where(p => p.CategoriaId == categoriaId)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao obter produto nesta categoria. {ex.Message}");
            }
        }

        public async Task<Produto?> ObterPorId(int id)
        {
            try
            {
                return await _context.Produtos.Include(p => p.Categoria)
                    .FirstOrDefaultAsync(p => p.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao obter produto com este ID. {ex.Message}");
            }
        }

        public async Task<Produto?> ObterPorNome(string nome)
        {
            try
            {
                return await _context.Produtos.FirstOrDefaultAsync(p => p.Nome == nome);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao obter produto com este NOME. {ex.Message}");
            }
        }

        public async Task<Produto> Inserir(Produto entity)
        {
            try
            {
                _context.Produtos.Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir produto. {ex.Message}");
            }
        }

        public async Task<Produto> Atualizar(Produto entity)
        {
            try
            {
                _context.Produtos.Update(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar produto. {ex.Message}");
            }
        }

        public async Task<bool> Deletar(int id)
        {
            try
            {
                var produto = await ObterPorId(id);
                if(produto == null) return false;

                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao deletar produto. {ex.Message}");
            }
        }

        public async Task<bool> PossuiMovimentacoes(int produtoId)
        {
            try
            {
                return await _context.Movimentacoes.AnyAsync(m => m.ProdutoId == produtoId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Este produto possui movimentações. {ex.Message}");
            }
        }
    }
}
