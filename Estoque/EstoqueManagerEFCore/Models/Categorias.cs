namespace EstoqueManagerEFCore.Models
{
    public class Categorias
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
    }
}
