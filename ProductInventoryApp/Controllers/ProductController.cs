using Microsoft.AspNetCore.Mvc;
using ProductInventoryApp.Models;
using ProductInventoryApp.Data;
using System.Linq;

namespace ProductInventoryApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        // Crearea unui produs (GET)
        public IActionResult Create()
        {
            return View();
        }

        // Crearea unui produs (POST)
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // Afisarea tuturor produselor si a produsului cu cel mai mare pret
        public IActionResult Index()
        {
            var produse = _context.Products.OrderBy(p => p.Pret).ToList(); // Sortare dupa pret
            var produsulCelMaiScump = _context.Products.OrderByDescending(p => p.Pret).FirstOrDefault(); // Produsul cu cel mai mare pret

            // Pasam la view ambele liste
            ViewBag.ProdusulCelMaiScump = produsulCelMaiScump;

            return View(produse);
        }
    }
}
