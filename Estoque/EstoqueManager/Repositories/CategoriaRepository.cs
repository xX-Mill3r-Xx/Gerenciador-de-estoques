using Dapper;
using EstoqueManager.Data.Services;
using EstoqueManager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueManager.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository<Categorias>
    {
        #region Properties

        private readonly string _connectionString;

        #endregion

        #region Constructors

        public CategoriaRepository(string connection)
        {
            _connectionString = connection;
        }

        #endregion

        public async Task<IEnumerable<Categorias>> ObterTodos()
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string sql = @"SELECT Id, Nome FROM Categorias";
                    await connection.OpenAsync();
                    var categorias = await connection.QueryAsync<Categorias>(sql);
                    return categorias;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return Enumerable.Empty<Categorias>();
            }
        }

        public async Task<Categorias> ObterPorId(int id)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string sql = @"SELECT Id, Nome FROM Categorias WHERE Id = @Id";

                    await connection.OpenAsync();
                    var categoria = await connection.QueryFirstOrDefaultAsync<Categorias>(sql, new { Id = id });
                    return categoria;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public async Task<Categorias> ObterPorNome(string nome)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string sql = @"SELECT Id, Nome FROM Categorias WHERE Nome = @Nome";

                    await connection.OpenAsync();
                    var categoria = await connection.QueryFirstOrDefaultAsync<Categorias>(sql, new { Nome = nome });
                    return categoria;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public async Task<Categorias> Inserir(Categorias entity)
        {
            try
            {
                var sql = @"INSERT INTO Categorias (Nome) VALUES (@Nome);
                                SELECT CAST(SCOPE_IDENTITY() as int);";

                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();
                    var idGerado = await connection.ExecuteScalarAsync<int>(sql, new
                    {
                        entity.Nome
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

        public async Task<Categorias> Atualizar(Categorias entity)
        {
            try
            {
                string sql = @"UPDATE Categorias SET Nome = @Nome WHERE Id = @Id";

                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();
                    int linhas = await connection.ExecuteAsync(sql, new
                    {
                        entity.Nome,
                        entity.Id
                    });

                    if(linhas > 0)
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

        public async Task<Categorias> Deletar(int id)
        {
            try
            {
                var categoria = await ObterPorId(id);
                if (categoria == null)
                    return null;
                string sql = @"DELETE FROM Categorias WHERE Id = @Id";
                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();
                    int linhas = await connection.ExecuteAsync(sql, new { Id = id});
                    return linhas > 0 ? categoria : null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
