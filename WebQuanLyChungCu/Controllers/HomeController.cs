using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebQuanLyChungCu.Models;

namespace WebQuanLyChungCu.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly QUANLYCHUNGCUContext _context;
        public INotyfService _notyfService { get; }
        public HomeController(ILogger<HomeController> logger, QUANLYCHUNGCUContext context,INotyfService notyfService)
        {
            _logger = logger;
            _context = context;
            _notyfService = notyfService;
        }
            
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Getdata()
        {
            var data = _context.Buildings.ToList();
            return Ok(data);
        }

        public IActionResult Privacy()
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