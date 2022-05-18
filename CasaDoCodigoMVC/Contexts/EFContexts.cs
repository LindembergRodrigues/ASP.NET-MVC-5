using CasaDoCodigoMVC.Models;
using System.Data.Entity;

namespace CasaDoCodigoMVC.Contexts
{
    public class EFContexts : DbContext 
    {
        public EFContexts() : base("Asp_Net_MVC_CS") { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }

    }
}
