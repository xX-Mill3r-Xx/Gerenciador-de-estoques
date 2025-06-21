using Dapper;
using EstoqueManager.Data.Services;
using EstoqueManager.Models;
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
	                                    Id, 
	                                    Nome, 
	                                    Quantidade, 
	                                    Preco, 
	                                    CategoriaId 
                                    FROM Produtos";
                    await connection.OpenAsync();
                    var produtos = await connection.QueryAsync<Produto>(sql);
                    return produtos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return Enumerable.Empty <Produto>();
            }
        }

        public async Task<Produto> ObterPorId(int id)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string sql = @"SELECT 
	                                    Id, 
	                                    Nome, 
	                                    Quantidade, 
	                                    Preco, 
	                                    CategoriaId 
                                    FROM Produtos
                                    WHERE Id = @Id";

                    await connection.OpenAsync();
                    var produto = await connection.QueryFirstOrDefaultAsync<Produto>(sql, new { Id = id });
                    return produto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
	                                    Id, 
	                                    Nome, 
	                                    Quantidade, 
	                                    Preco, 
	                                    CategoriaId 
                                    FROM Produtos
                                    WHERE Nome LIKE @Nome";

                    await connection.OpenAsync();
                    var produto = await connection.QueryFirstOrDefaultAsync<Produto>(sql, new { Nome = nome });
                    return produto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public Task<Produto> Atualizar(Produto entity)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> Deletar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
