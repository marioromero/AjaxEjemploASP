using AjaxEjemplo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AjaxEjemplo.Controllers
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
        public IActionResult testAjax(Usuario usuario)
        {
            Usuario usuariobd = new Usuario()
            {
                CorreoElectronico = "usuariocorrecto@mail.com",
                Password = "123456"
            };

            if (usuario.CorreoElectronico == usuariobd.CorreoElectronico && usuario.Password == usuariobd.Password)
            {
                return Json(new { success = true, redirectUrl = Url.Action("Intranet", "Home") });
            }
            else
            {
                return Json(new { success = false, message = "Usuario incorrecto" });
            }
        }

        public IActionResult Intranet()
        {
            return View();
        }
    }
}

public class Usuario
{
    public string CorreoElectronico { get; set; }
    public string Password { get; set; }
}