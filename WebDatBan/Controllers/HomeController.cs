using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebDatBan.Models;
using DTO;
using BUS;
namespace WebDatBan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

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
            try
            {
                BookingBUS.Instance.InsertCategory(ct);
                TempData["Sucess"] = "Đặt bàn thành công.!";
                return RedirectToAction("index");
            }
            catch (Exception)
            {

                return RedirectToAction("index");
            }
        }
    }
}