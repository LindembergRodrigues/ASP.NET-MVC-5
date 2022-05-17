using CasaDoCodigoMVC.Models;
using Microsoft.AspNetCore.Mvc;
 
namespace CasaDoCodigoMVC.Controllers
{
    public class CategoriaController : Controller
    {
        private static List<Categoria> categorias = new List<Categoria>()
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

        public IActionResult Edit(int id)
        {

            //var produto = categorias.Where(y => y.CategoriaId.Equals(id)).Select(x => x.Nome).ToString();
            //ViewData["Produto"] = produto;
            var produto = categorias.FindAll(x => x.CategoriaId.Equals(id)).ToList();

            return View(produto) ;
        }
    }
}
