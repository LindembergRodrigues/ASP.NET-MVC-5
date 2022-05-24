using CasaDoCodigoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigoMVC.Controllers
{
    public class CategoriaController : Controller
    {
        private static IList<Categoria> categorias = new List<Categoria>()
        {
            new Categoria(){
                CategoriaId = 1,
                Nome = "Notebooks"
            },
            new Categoria()
            {
                CategoriaId = 2,
                Nome = "Monitores"
            },
            new Categoria()
            {
                CategoriaId = 3,
                Nome = "Impressoras"
            },
            new Categoria()
            {
                CategoriaId = 4,
                Nome = "Mouses"
            },
            new Categoria(){
                CategoriaId = 5,
                 Nome ="Desktops"
            }
        };

        public IActionResult Index()
        {
            return View(categorias);
        }

        public IActionResult Edit(long id)
        {

            //var produto = categorias.Where(y => y.CategoriaId.Equals(id)).Select(x => x.Nome).ToString();
            //ViewData["Produto"] = produto;
            //var produto = categorias.FindAll(x => x.CategoriaId.Equals(id)).ToList();

            return View(categorias.Where(c => c.CategoriaId == id).First());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Categoria categoria)
        {
            categorias.Add(categoria);
            categoria.CategoriaId = categorias.Select(c => c.CategoriaId).Max() + 1;
            return RedirectToAction("Index");
        }

        public IActionResult Details(long id)
        {
            return View(categorias.Where(c => c.CategoriaId == id).First());
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Delete(long id)
        {
            categorias.Remove(categorias.Where(c => c.CategoriaId == id).First());
            return RedirectToAction("Index");
        }
    }
}
