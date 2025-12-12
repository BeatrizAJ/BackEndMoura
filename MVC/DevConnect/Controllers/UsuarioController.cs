using System.Threading.Tasks;
using DevConnect.Context;
using DevConnect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevConnect.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ILogger<UsuarioController> _logger;

        private readonly DevConnectContext _context;

        public UsuarioController(ILogger<UsuarioController> logger, DevConnectContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.UsuarioNovoCadastrado = "";
            TempData["UsuarioNovoCadastrado"] = "";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(IFormCollection form)
        {
            TbUsuario novoUsuario = new TbUsuario()
            {
                NomeCompleto = form["NomeCompleto"].ToString(),
                NomeUsuario = form["NomeCompleto"].ToString(),
                Email = form["Email"].ToString(),
                Senha = form["Senha"].ToString()
            };
            if (form.Files.Count > 0)
            {
                IFormFile file = form.Files[0];
                string folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                string path = Path.Combine(folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                novoUsuario.FotoPerfilUrl = file.FileName;
            }
            else
            {
                novoUsuario.FotoPerfilUrl = "";
            }

            try
            {
                _context.TbUsuario.Add(novoUsuario);

                await _context.SaveChangesAsync();

                TempData["UsuarioNovoCadastrado"] = "Cadastrado";
                ViewBag.UsuarioNovoCadastrado = "";

                return RedirectToAction("Index", "Home");
            }
            catch (System.Exception)
            {
                ViewBag.UsuarioNovoCadastrado = "Nao cadastrado";
                TempData["UsuarioNovoCadastrado"] = "";
                throw;
            }


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
