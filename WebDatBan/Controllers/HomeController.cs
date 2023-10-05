using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebDatBan.Models;

namespace WebDatBan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        CoffeeManagementContext db= new CoffeeManagementContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Booking ct)
        {
           
            if (ModelState.IsValid)
            {
                db.Bookings.Add(ct);
                db.SaveChanges();
                TempData["Sucess"] = "Tạo thành công.!";
                return RedirectToAction("index");
            }
            return View(ct);
        }
    }
}