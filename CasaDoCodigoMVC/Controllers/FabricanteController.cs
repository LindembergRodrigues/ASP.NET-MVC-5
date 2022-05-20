using CasaDoCodigoMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigoMVC.Controllers
{
    public class FabricanteController : Controller
    {
        private EFContext context = new EFContext();
        public IActionResult Index()
        {
            return View(context.Fabricante.OrderBy(c => c.Nome));
        }
    }
}
