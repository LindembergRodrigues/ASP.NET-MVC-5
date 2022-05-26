namespace CasaDoCodigoMVC.Models
{
    public class Fabricante
    {
        [key]
        public long FabricanteId { get; set; }
        public string Nome { get; set; }

        public bool IsAtivo { get; set; }
        //public ICollection<Produto> Produtos { get; set; }
    }
}
