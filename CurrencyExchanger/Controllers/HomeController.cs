using CurrencyExchanger.Models;
using CurrencyExchanger.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CurrencyExchanger.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext context;

       
        public HomeController(ApplicationDbContext context  )
        {
            this.context = context;
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
    }
}
