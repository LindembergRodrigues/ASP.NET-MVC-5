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

        public DbSet<CasaDoCodigoMVC.Models.Fabricante>? Fabricante { get; set; }
    }
}
