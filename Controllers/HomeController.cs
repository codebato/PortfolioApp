using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Models;

namespace PortfolioApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Statik veri - veritabanı yok, sadece model dolduruluyor.
            var model = new PortfolioViewModel();
            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
