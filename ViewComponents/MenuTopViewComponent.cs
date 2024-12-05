using Souvenir.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Souvenir.ViewComponents
{
    public class MenuTopViewComponent : ViewComponent
    {
        private readonly SouvenirShopDbContext _context;

        public MenuTopViewComponent(SouvenirShopDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menutop = await _context.Menus
                .Where(h => h.IsActive == true && h.ParentId != null) // Lọc theo IsActive và ParentId khác null
                .OrderBy(h => h.ParentId) // Sắp xếp theo ParentId
                .ToListAsync();  // Lấy tất cả các menu phù hợp

            return View(menutop);  // Trả về View với danh sách menu
        }

    }
}
