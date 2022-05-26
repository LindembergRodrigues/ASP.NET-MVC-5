namespace CasaDoCodigoMVC.Models
{
    public class Produto
    {

        public int ProdutoID { get; set; }
        public string  Nome { get; set; }

        public int CategoriaId { get; set; }
        public int FabricanteId { get; set; }

        public Categoria Categorias { get; set; }
        public Fabricante Fabricantes { get; set; }
    }
}
