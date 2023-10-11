using ClassTest.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace ClassTest.Controllers
{
    public class ClassController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ClassController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult ClassSchedule()
        {
            var booking = _context.ClassSchedules.ToList();
            return View(booking);
        }

        public IActionResult Create()
        {
            var booking = _context.ClassSchedules.ToList();
            return View(booking);
        }
    }
}
