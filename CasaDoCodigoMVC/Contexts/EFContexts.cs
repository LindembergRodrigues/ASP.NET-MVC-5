using CasaDoCodigoMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CasaDoCodigoMVC.Contexts
{
    public class EFContexts : DbContext 
    {
        public EFContexts(DbContextOptions<EFContexts> option) 
            : base(option) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }

    }
}
