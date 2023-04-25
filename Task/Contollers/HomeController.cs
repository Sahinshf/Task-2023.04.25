using Microsoft.AspNetCore.Mvc;
using Task.Contexts;
using Task.Models;

namespace Task.Contollers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context; 
        }

        public IActionResult Index()
        {
            List<Service> services = _context.Services.ToList(); 

            return View(services);
        }
    }
}
