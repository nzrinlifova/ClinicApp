using ClinicApp.Contexts;
using ClinicApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicApp.Areas.Admin.Controllers
{
    [Area ("Admin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;
        public DashboardController()
        {
            _context = new AppDbContext();
        }
        public IActionResult Index()
        {
            List<Doctor>doctors=_context.doctors.ToList();
            return View(doctors);
        }
        public IActionResult Table()
        {
            List<Doctor> doctors = _context.doctors.ToList();
            return View(doctors);
        }
    }
}
