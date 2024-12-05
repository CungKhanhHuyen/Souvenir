using Souvenir.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Souvenir.ViewComponents
{
    public class MenuFoodViewComponent : ViewComponent
    {
        private readonly SouvenirShopDbContext _context;
        public MenuFoodViewComponent(SouvenirShopDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int? CategoryID)
        {
            var menufood = CategoryID == null ? await _context.Products.ToListAsync() : await _context.Products.Where(h => h.CategoryId == CategoryID).ToListAsync();
            return View(menufood);
        }
    }
}
