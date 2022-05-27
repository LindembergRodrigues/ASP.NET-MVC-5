using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasaDoCodigoMVC.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoID { get; set; }
        [Required(ErrorMessage = "Informe o nome do produto!")]
        public string  Nome { get; set; }
        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        [ForeignKey("Fabricante")]
        public int FabricanteId { get; set; }

        public Categoria Categorias { get; set; }
        public Fabricante Fabricantes { get; set; }
    }
}
