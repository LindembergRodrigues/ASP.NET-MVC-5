using System.Data.Entity;

namespace CasaDoCodigoMVC.Contexts
{
    public class EFContexts : DbContext 
    {
        public EFContexts() : base("Asp_Net_MVC_CS") { }

    }
}
