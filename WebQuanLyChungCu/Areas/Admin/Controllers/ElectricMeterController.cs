using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using WebQuanLyChungCu.Models;

namespace WebQuanLyChungCu.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ElectricMeterController : Controller
    {
        private QUANLYCHUNGCUContext _context;
        public INotyfService _notyfService { get; }
        public ElectricMeterController(QUANLYCHUNGCUContext repo, INotyfService notyfService)
        {
            _context = repo;
            _notyfService = notyfService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
