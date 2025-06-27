using EstoqueManagerEFCore.Models;
using EstoqueManagerEFCore.Models.Configuracoes;
using Microsoft.EntityFrameworkCore;

namespace EstoqueManagerEFCore.Data
{
    public class EstoqueManagerContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Movimentacao> Movimentacoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var conexao = StringConnection.Conexao();
                optionsBuilder.UseSqlServer(conexao);
            }
        }
    }
}
