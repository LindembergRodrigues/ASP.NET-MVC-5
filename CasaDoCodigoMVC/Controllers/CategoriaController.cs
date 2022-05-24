using CasaDoCodigoMVC.Data;
using CasaDoCodigoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigoMVC.Controllers
{
    public class CategoriaController : Controller
    {
        EFContext context = new EFContext();

        //private static IList<Categoria> categorias = new List<Categoria>()
        //{
        //    new Categoria(){
        //        CategoriaId = 1,
        //        Nome = "Notebooks"
        //    },
        //    new Categoria()
        //    {
        //        CategoriaId = 2,
        //        Nome = "Monitores"
        //    },
        //    new Categoria()
        //    {
        //        CategoriaId = 3,
        //        Nome = "Impressoras"
        //    },
        //    new Categoria()
        //    {
        //        CategoriaId = 4,
        //        Nome = "Mouses"
        //    },
        //    new Categoria(){
        //        CategoriaId = 5,
        //         Nome ="Desktops"
        //    }
        //};

        public IActionResult Index()
        {
            return View(context.categoria.OrderBy( f => f.Nome));
        }

        public IActionResult Edit(long id)
        {

            //var produto = categorias.Where(y => y.CategoriaId.Equals(id)).Select(x => x.Nome).ToString();
            //ViewData["Produto"] = produto;
            //var produto = categorias.FindAll(x => x.CategoriaId.Equals(id)).ToList();

            return View(context.categoria.Where(c => c.CategoriaId == id).First());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Categoria categoria)
        {
            context.categoria.Add(categoria);
            context.SaveChanges();
            return RedirectToAction();
        }

        public IActionResult Details(long id)
        {
            return View(context.categoria.Where(c => c.CategoriaId == id).First());
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Delete(long id)
        {
            //var teste = context.categoria.Where(c => c.CategoriaId == id).First();
            context.categoria.Remove(context.categoria.Find(id));
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
