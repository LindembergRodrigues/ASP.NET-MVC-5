using CasaDoCodigoMVC.Data;
using CasaDoCodigoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using System.Net;

namespace CasaDoCodigoMVC.Controllers
{
    public class FabricanteController : Controller
    {
        private EFContext context = new EFContext();
        public IActionResult Index()
        {
            return View(context.Fabricante.OrderBy(c => c.Nome + "-"));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Fabricante fabricante)
        {
            using (var _context = new EFContext())
            {
                _context.Fabricante.Add(fabricante);
                _context.SaveChanges();
            }
            return RedirectToAction();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Fabricante fabricante)
        {
            if (ModelState.IsValid)
            {
                context.Entry(fabricante).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fabricante);
        }
        public IActionResult Edit(long id)
        {
            if (id == null)
            {
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);
            }
            Fabricante fabricante = context.Fabricante.Find(id);
            if (fabricante == null)
            {
                return NotFound(); //HttpNotFound(); 
            }

            return View(fabricante);
        }

        public IActionResult Delete(long id)
        {
            Fabricante fabricante = context.Fabricante.Find(id);
            context.Fabricante.Remove(fabricante);
            context.SaveChanges();

            return RedirectToAction("Index");

        }

        public IActionResult Details(long id)
        {
            return View(context.Fabricante.Find(id));
        }
    }
}
