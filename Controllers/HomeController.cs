using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _23210202037.Models;
using _23210202037.Data;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace _23210202037.Controllers
{
    [Authorize]
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

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            List<Image> images = await _context.Images.ToListAsync();
            return View(images);
        }
        
        // [Authorize] özniteliğini kaldırın çünkü sınıf seviyesinde zaten bulunuyor
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
    }
}