using EstoqueManagerEFCore.Models;
using EstoqueManagerEFCore.Models.Configuracoes;
using Microsoft.EntityFrameworkCore;

namespace EstoqueManagerEFCore.Data
{
    public class EstoqueManagerContext : DbContext
    {
        public DbSet<ConfiguracaoBD> ConfiguracaoBDs {  get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categorias> Categorias { get; set; }

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
