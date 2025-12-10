using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevConnect.Controllers
{
    [Route("Usuario")]
    public class UsuarioController : Controller
    {
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
        }

        // ROTA: /Usuario
        // ou /Usuario/Index
        [Route("")]
        [Route("Index")]
        
        //CADASTRO
        public IActionResult Index()
        {
            return View();
        }

        // ROTA: /Usuario/Perfil
        [Route("Perfil")]
        public IActionResult Perfil()
        {
            return View();
        }

        // ROTA: /Usuario/Cadastros
        // [Route("Cadastros")]
        // public IActionResult Cadastros()
        // {
        //     return View();
        // }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
