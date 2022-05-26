using System.ComponentModel.DataAnnotations;

namespace CasaDoCodigoMVC.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [Required (ErrorMessage = "Informe um nome!")]
        public string Nome{ get; set; }
        public bool IsAtivo { get; set; }
        
        //public ICollection<Produto> Produtos { get; set; }

    }
}
