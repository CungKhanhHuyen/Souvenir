using Microsoft.AspNetCore.Mvc;
using Souvenir.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
namespace Souvenir.Controllers
{
    public class ProductController : Controller
    {
        private readonly SouvenirShopDbContext _context;
        public ProductController(SouvenirShopDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("/product/{alias}-{id}.html")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }
            var productItem = await _context.Products.Include(i => i.Category).FirstOrDefaultAsync(i => i.ProductId == id);
            if (productItem == null)
            {
                return NotFound();

            }
            return View(productItem);
        }
    }
}
