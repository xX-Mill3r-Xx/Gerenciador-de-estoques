using System.ComponentModel.DataAnnotations.Schema;

namespace EstoqueManagerEFCore.Models
{
    [Table("Produtos")]
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public decimal Preco { get; set; }

        public Categoria? Categoria { get; set; }
    }
}
