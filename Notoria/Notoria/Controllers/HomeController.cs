using Microsoft.AspNetCore.Mvc;
using Notoria.Models;
using System.Diagnostics;

namespace Notoria.Controllers
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

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Contratos()
        {
            return View();
        }

        public IActionResult Empresa()
        {
            return View();
        }

        public IActionResult Usuario()
        {
            return View();
        }

        public IActionResult Invitado()
        {
            return View();
        }

        public IActionResult Calculadora()
        {
            return View();
        }

        public IActionResult Perfil()
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