using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //acao padrao inicial
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult MinhaAcao()
    {
        //retorne a pagina MinhaAcao.cshtml
        return View();
    }

    public IActionResult ListarNomes()
    {
      
        string[] nomes = {"Beatriz","Nathalia","Giovanna"};
        ViewBag.nomes = nomes;
        ViewBag.Teste = "Ola, eu vim atravez da ViewBag";

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
