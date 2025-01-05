using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _23210202037.Models;
using _23210202037.Data;
using System.Linq;

namespace _23210202037.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        // Yalnızca bir constructor bırakıldı
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Blog()
        {
            var districts = _context.Districts.ToList();
            return View(districts);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // Diğer constructor'lar varsa, aşağıdaki gibi yorum satırı yapın:
        /*
        public HomeController()
        {
            // Boş constructor
        }
        */
    }
}