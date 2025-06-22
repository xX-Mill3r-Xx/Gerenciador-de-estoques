using Dapper;
using EstoqueManager.Data.Services;
using EstoqueManager.Models;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueManager.Data.Repositories
{
    public class MovimentacoesRepository : IMovimentacoesRepository
    {
        #region Properties

        private readonly string _connectionString;

        #endregion

        #region Constructors

        public MovimentacoesRepository(string connection)
        {
            _connectionString = connection;
        }

        #endregion

        public async Task RegistrarMovimento(Movimentacoes movimento)
        {
            try
            {
                const string sql = @"INSERT INTO Movimentacoes (ProdutoId, Tipo, Quantidade, DataMovimento) 
                VALUES (@ProdutoId, @Tipo, @Quantidade, @DataMovimento);
                UPDATE Produtos
                SET Quantidade = Quantidade + (CASE WHEN @Tipo = 'E' THEN @Quantidade ELSE -@Quantidade END)
                WHERE Id = @ProdutoId;";

                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();
                    await connection.ExecuteAsync(sql, movimento);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
