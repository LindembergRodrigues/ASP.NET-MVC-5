namespace CasaDoCodigoMVC.Models
{
    public class Produto
    {

        public int PrudutoID { get; set; }
        public String  Nome { get; set; }

        public int CategoriaId { get; set; }
        public int FabricanteId { get; set; }
        public Categoria categoria { get; set; }
        public Fabricante fabricante { get; set; }
    }
}
