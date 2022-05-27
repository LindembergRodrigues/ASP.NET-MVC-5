using System.ComponentModel.DataAnnotations;

namespace CasaDoCodigoMVC.Models
{
    public class Fabricante
    {
        [Key]
        public long FabricanteId { get; set; }

        [Required(ErrorMessage = "Informe um nome para o fabricante!")]
        public string Nome { get; set; }

        public bool IsAtivo { get; set; }
        //public ICollection<Produto> Produtos { get; set; }
    }
}
