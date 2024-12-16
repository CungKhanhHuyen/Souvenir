using Souvenir.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
namespace Souvenir.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
    private readonly SouvenirShopDbContext _context;
       public BlogViewComponent(SouvenirShopDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menufood = await _context.Blogs.ToListAsync();
            return View(menufood);
        }
    }
}
