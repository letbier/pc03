using System.Linq;
using busco.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace busco.Controllers
{
    public class BuscoController : Controller
    {
        
          private readonly BuscoContext _context;

           public BuscoController(BuscoContext context) {
            _context = context;
        }

        public IActionResult Categorias() {
            var categorias = _context.Categoria.OrderBy(r => r.Nombre).ToList();
            return View(categorias);
        }

        public IActionResult Pedidos() {
            var clientes = _context.Clientes.Include(x => x.Categoria).OrderBy(r => r.NombreProducto).ToList();
            return View(clientes);
        }

        public IActionResult RegistrarPedido() {
            ViewBag.Categoria = _context.Categoria.ToList().Select(r => new SelectListItem(r.Nombre, r.Id.ToString()));
            return View();
        }
        [HttpPost]
        public IActionResult RegistrarPedido(Cliente r) {
            if (ModelState.IsValid) {
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("Pedidos");
            }
            return View(r);
        }
        public IActionResult ListaCategorias() {
            return View();
        }
         [HttpPost]
        public IActionResult ListaCategorias(Categoria r) {
            if (ModelState.IsValid) {
                _context.Add(r);
                _context.SaveChanges();
            }
            return View(r);
        }


    }
}