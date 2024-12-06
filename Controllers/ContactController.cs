using Microsoft.AspNetCore.Mvc;
using Souvenir.Models;

namespace Souvenir.Controllers
{
    public class ContactController : Controller
    {
        private readonly SouvenirShopDbContext _context;
        public ContactController(SouvenirShopDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string name,string email, string message)
        {
            try
            {
                Contact contact = new Contact();
                contact.FullName = name;
                contact.Email = email;
                contact.Message = message;
                contact.CreatedAt = DateTime.Now;
                _context.Add(contact);
                _context.SaveChangesAsync();

                return Json(new { status = true });

            }
            catch
            {
                return Json(new { status = false });
            }
        }
    }
}
