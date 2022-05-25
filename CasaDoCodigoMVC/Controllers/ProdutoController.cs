using CasaDoCodigoMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigoMVC.Controllers
{
    public class ProdutoController : Controller
    {
        EFContext context = new EFContext();
        public IActionResult Index()
        {
            return View();
        }
    }
}
