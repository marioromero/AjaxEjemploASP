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
        public JsonResult testAjax(Usuario usuario)
        {

            string mensaje = "hola desde método";

            bool usuarioLogeado = false;


            /*if (usuarioLogeado)
            {
                return View("")
            }
            else
            {
                return Json(mensaje);
            }*/

            return Json(mensaje);
        }
    }
}

public class Usuario
{
    public string CorreoElectronico { get; set; }
    public string Password { get; set; }
}