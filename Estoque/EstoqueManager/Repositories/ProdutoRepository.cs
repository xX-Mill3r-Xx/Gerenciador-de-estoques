using Dapper;
using EstoqueManager.Data.Services;
using EstoqueManager.Models;
using EstoqueManager.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueManager.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository<Produto>
    {
        #region Properties

        private readonly string _connectionString;

        #endregion

        #region Constructors

        public ProdutoRepository(string connection)
        {
            _connectionString = connection;
        }

        #endregion Constructors

        public async Task<IEnumerable<Produto>> ObterTodos()
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string sql = @"SELECT 
	                                    produto.Id, 
	                                    produto.Nome, 
	                                    produto.Quantidade, 
	                                    produto.Preco, 
	                                    produto.CategoriaId,
	                                    categoria.Nome AS Categoria
                                    FROM Produtos produto
	                                    JOIN Categorias categoria ON produto.CategoriaId = categoria.Id";
                    await connection.OpenAsync();
                    var produtos = await connection.QueryAsync<Produto>(sql);
                    return produtos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Mensagens.ErroDeBusca(ex), 
                    Mensagens.Erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Enumerable.Empty<Produto>();
            }
        }

        public async Task<IEnumerable<Produto>> ObterPorCategoria(int categoriaId)
        {
            try
            {
                const string sql = @"SELECT 
	                                    produto.Id, 
	                                    produto.Nome, 
	                                    produto.Quantidade, 
	                                    produto.Preco, 
	                                    produto.CategoriaId,
	                                    categoria.Nome AS Categoria
                                    FROM Produtos produto
	                                    JOIN Categorias categoria ON produto.CategoriaId = categoria.Id
                                    WHERE produto.CategoriaId = @CategoriaId";

                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();
                    var produtos = await connection.QueryAsync<Produto>(sql, new { CategoriaId = categoriaId });
                    return produtos ?? Enumerable.Empty<Produto>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Mensagens.ErroDeBusca(ex),
                    Mensagens.Erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Enumerable.Empty<Produto>();
            }
        }

        public async Task<Produto> ObterPorId(int id)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string sql = @"SELECT 
	                                    produto.Id, 
	                                    produto.Nome, 
	                                    produto.Quantidade, 
	                                    produto.Preco, 
	                                    produto.CategoriaId,
	                                    categoria.Nome AS Categoria
                                    FROM Produtos produto
	                                    JOIN Categorias categoria ON produto.CategoriaId = categoria.Id
                                    WHERE produto.Id = @Id";

                    await connection.OpenAsync();
                    var produto = await connection.QueryFirstOrDefaultAsync<Produto>(sql, new { Id = id });
                    return produto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Mensagens.ErroDeBusca(ex),
                    Mensagens.Erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<Produto> ObterPorNome(string nome)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string sql = @"SELECT 
	                                    produto.Id, 
	                                    produto.Nome, 
	                                    produto.Quantidade, 
	                                    produto.Preco, 
	                                    produto.CategoriaId,
	                                    categoria.Nome AS Categoria
                                    FROM Produtos produto
	                                    JOIN Categorias categoria ON produto.CategoriaId = categoria.Id
                                    WHERE produto.Nome LIKE @Nome";

                    await connection.OpenAsync();
                    var produto = await connection.QueryFirstOrDefaultAsync<Produto>(sql, new { Nome = nome });
                    return produto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Mensagens.ErroDeBusca(ex),
                    Mensagens.Erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<Produto> Inserir(Produto entity)
        {
            try
            {
                var sql = @"
                            INSERT INTO Produtos (Nome, Quantidade, CategoriaId, Preco)
                            VALUES (@Nome, @Quantidade, @CategoriaId, @Preco);
                            SELECT CAST(SCOPE_IDENTITY() as int);";

                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();
                    var idGerado = await connection.ExecuteScalarAsync<int>(sql, new
                    {
                        entity.Nome,
                        entity.Quantidade,
                        entity.CategoriaId,
                        entity.Preco
                    });

                    entity.Id = idGerado;
                    return entity;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Mensagens.ErroAoInserir(ex), 
                    Mensagens.Erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<Produto> Atualizar(Produto entity)
        {
            try
            {
                string sql = @"UPDATE Produtos
                                SET Nome = @Nome,
	                                Quantidade = @Quantidade,
	                                Preco = @Preco,
	                                CategoriaId = @CategoriaId
                                WHERE Id = @Id";
                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();
                    int linhas = await connection.ExecuteAsync(sql, new
                    {
                        entity.Nome,
                        entity.Quantidade,
                        entity.CategoriaId,
                        entity.Preco,
                        entity.Id
                    });

                    if (linhas > 0)
                        return entity;
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public async Task<Produto> Deletar(int id)
        {
            try
            {
                var produto = await ObterPorId(id);
                if (produto == null)
                    return null;
                string sql = @"DELETE FROM Produtos WHERE Id = @Id";
                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();
                    int linhas = await connection.ExecuteAsync(sql, new { Id = id });
                    return linhas > 0 ? produto : null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public async Task<bool> PossuiMovimentacoes(int produtoId)
        {
            try
            {
                const string sql = "SELECT COUNT(*) FROM Movimentacoes WHERE ProdutoId = @ProdutoId";

                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();
                    int cout = await connection.ExecuteScalarAsync<int>(sql, new { ProdutoId = produtoId });
                    return cout > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
