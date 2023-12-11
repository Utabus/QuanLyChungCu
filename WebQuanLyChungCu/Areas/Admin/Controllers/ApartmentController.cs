using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebQuanLyChungCu.Models;

namespace WebQuanLyChungCu.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ApartmentController : Controller
    {
        private QUANLYCHUNGCUContext _context;
        public INotyfService _notyfService { get; }
        public ApartmentController(QUANLYCHUNGCUContext repo, INotyfService notyfService)
        {
            _context = repo;
            _notyfService = notyfService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Apartments.Include(x => x.Building).ToListAsync());
        }
        public IActionResult Create()
        {
            ViewData["BuildingId"] = new SelectList(_context.Buildings, "BuildingId", "BuildingName");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Apartment apartment)
        {
            var ToaNha = await _context.Buildings.FirstOrDefaultAsync(x => x.BuildingId == apartment.BuildingId);
            var CanHo = await _context.Apartments.FirstOrDefaultAsync(x =>x.FloorNumber == apartment.FloorNumber && x.ApartmentNumber == apartment.ApartmentNumber && x.Building.BuildingId == apartment.BuildingId);
            if (CanHo != null)
            {
                _notyfService.Error("Căn hộ trùng với căn hộ đã thêm trước đó");
                return View();
            }
            apartment.ApartmentCode = ToaNha?.BuildingCode + "-" + (apartment.FloorNumber < 10 ? "0" : "")
                + apartment.FloorNumber + (apartment.ApartmentNumber < 10 ? "0" : "") + apartment.ApartmentNumber;
            apartment.ApartmentName = (ToaNha?.BuildingName?[ToaNha.BuildingName.Length - 1]).ToString()
                + "-" + apartment.FloorNumber + "-" + apartment.ApartmentNumber;
            _context.Add(apartment);
            await _context.SaveChangesAsync();
            _notyfService.Success("Thêm thành công");
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Apartments == null)
            {
                return NotFound();
            }
            var CanHo = await _context.Apartments.FindAsync(id);
            if (CanHo == null)
            {
                return NotFound();
            }
            
            return View(CanHo);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Apartments == null)
            {
                return NotFound();
            }
            var CanHo = await _context.Apartments.FindAsync(id);
            if (CanHo == null)
            {
                return NotFound();
            }
            ViewData["BuildingId"] = new SelectList(_context.Buildings, "BuildingId", "BuildingName");
            return View(CanHo);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Apartment apartment)
        {
            var ToaNha = await _context.Buildings.FirstOrDefaultAsync(x => x.BuildingId == apartment.BuildingId);
            var CanHo = await _context.Apartments.FirstOrDefaultAsync(x => x.ApartmentId != apartment.ApartmentId
            && x.FloorNumber == apartment.FloorNumber && x.ApartmentNumber == apartment.ApartmentNumber && x.Building.BuildingId == apartment.BuildingId);
            if (CanHo != null)
            {
                _notyfService.Error("Căn hộ trùng với căn hộ đã có");
                ViewData["BuildingId"] = new SelectList(_context.Buildings, "BuildingId", "BuildingName");
                return View();
            }

            apartment.ApartmentCode = ToaNha?.BuildingCode + "-" + (apartment.FloorNumber < 10 ? "0" : "")
                + apartment.FloorNumber + (apartment.ApartmentNumber < 10 ? "0" : "") + apartment.ApartmentNumber;
            apartment.ApartmentName = (ToaNha?.BuildingName?[ToaNha.BuildingName.Length - 1]).ToString()
                + "-" + apartment.FloorNumber + "-" + apartment.ApartmentNumber;
            _context.Update(apartment);
            await _context.SaveChangesAsync();
            _notyfService.Success("Sửa thành công");
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Apartments == null)
            {
                return NotFound();
            }
            var CanHo = await _context.Apartments.FindAsync(id);
            if (CanHo == null)
            {
                return NotFound();
            }
            return View(CanHo);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Apartments == null)
            {
                return Problem("Entity set 'QUANLYCHUNGCUContext.Apartments'  is null.");
            }
            var CanHo = await _context.Apartments.FindAsync(id);
            if (CanHo != null)
            {
                _context.Apartments.Remove(CanHo);
            }
            _notyfService.Success("Xóa Thành Công");
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
