using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoAula.Models;

namespace ProjetoAula.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult home()
        {
            return View();
        }

        public IActionResult privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class LoginController : Controller
    {
        public IActionResult login()
        {
            return View();
        }
    }

    public class ContatoController : Controller
    {
        public IActionResult contato()
        {
            return View();
        }
    }

    public class CadastroController : Controller
    {
        public IActionResult cadastro()
        {
            return View();
        }
    }
}
