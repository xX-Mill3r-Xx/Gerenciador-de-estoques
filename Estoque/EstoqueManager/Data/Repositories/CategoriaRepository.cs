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

        public Task<Categorias> Atualizar(Categorias entity)
        {
            throw new NotImplementedException();
        }

        public Task<Categorias> Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Categorias> Inserir(Categorias entity)
        {
            throw new NotImplementedException();
        }

        public Task<Categorias> ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Categorias> ObterPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
