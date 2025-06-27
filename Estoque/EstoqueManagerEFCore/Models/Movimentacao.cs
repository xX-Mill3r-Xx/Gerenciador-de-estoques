using System.ComponentModel.DataAnnotations.Schema;

namespace EstoqueManagerEFCore.Models
{
    [Table("Movimentacoes")]
    public class Movimentacao
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public char Tipo { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataMovimento { get; set; }
    }
}
