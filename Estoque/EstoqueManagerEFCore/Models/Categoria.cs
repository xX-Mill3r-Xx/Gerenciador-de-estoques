using System.ComponentModel.DataAnnotations.Schema;

namespace EstoqueManagerEFCore.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
    }
}
