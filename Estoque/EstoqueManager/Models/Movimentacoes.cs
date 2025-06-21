using System;

namespace EstoqueManager.Models
{
    public class Movimentacoes
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public char Tipo { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataMovimento { get; set; }
    }
}
