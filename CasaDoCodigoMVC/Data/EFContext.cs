using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CasaDoCodigoMVC.Models;

namespace CasaDoCodigoMVC.Data
{
    public class EFContext : DbContext
    {
        public EFContext (DbContextOptions<EFContext> options)
            : base(options)
        {
        }

        public DbSet<Categoria>? categoria { get; set; }
        public DbSet<Fabricante>? Fabricante { get; set; }
    }
}
