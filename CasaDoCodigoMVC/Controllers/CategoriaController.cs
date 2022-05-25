using CasaDoCodigoMVC.Data;
using CasaDoCodigoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigoMVC.Controllers
{
    public class CategoriaController : Controller
    {
        EFContext context = new EFContext();

        public IActionResult Index()
        {
            return View(context.Categoria.OrderBy(f => f.Nome));
        }

        public IActionResult Edit(long id)
        {

            //var produto = categorias.Where(y => y.CategoriaId.Equals(id)).Select(x => x.Nome).ToString();
            //ViewData["Produto"] = produto;
            //var produto = categorias.FindAll(x => x.CategoriaId.Equals(id)).ToList();

            return View(context.Categoria.Where(c => c.CategoriaId == id).First());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Categoria categoria)
        {
            using (var _contexto = new EFContext())
            {
                _contexto.Categoria.Add(categoria);
                _contexto.SaveChanges();
            }
           // var teste = new Categoria { CategoriaId = 5, Nome = "Teste" };
            //Console.WriteLine(teste);

           // context.Categoria.Add(teste);
           // context.SaveChanges();
            return RedirectToAction();
        }

        public IActionResult Details(long id)
        {
            return View(context.Categoria.Where(c => c.CategoriaId == id).First());
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Delete(long id)
        {
            //var teste = context.categoria.Where(c => c.CategoriaId == id).First();
            context.Categoria.Remove(context.Categoria.Find(id));
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
