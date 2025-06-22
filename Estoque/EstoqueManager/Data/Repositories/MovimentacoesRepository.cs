using Dapper;
using EstoqueManager.Data.Services;
using EstoqueManager.Models;
using System;
using System.Collections.Generic;
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
                const string sql = @"
                INSERT INTO Movimentacoes (ProdutoId, Tipo, Quantidade) 
                    VALUES (@ProdutoId, @Tipo, @Quantidade);

                UPDATE Produtos
                    SET Quantidade = Quantidade + 
                    (CASE WHEN @Tipo = 'E' THEN @Quantidade ELSE -@Quantidade END)
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

        public async Task<IEnumerable<Movimentacoes>> ObterPorProduto(int produtoId)
        {
            try
            {
                const string sql = @"SELECT Id, ProdutoId, Tipo, Quantidade, DataMovimento
                                        FROM Movimentacoes
                                        WHERE ProdutoId = @ProdutoId
                                        ORDER BY DataMovimento DESC";

                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();
                    var movimentacoes = await connection.QueryAsync<Movimentacoes>(sql, new { ProdutoId = produtoId });
                    return movimentacoes;
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
