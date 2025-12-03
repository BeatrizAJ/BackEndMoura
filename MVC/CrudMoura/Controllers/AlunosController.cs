using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CrudMoura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrudMoura.Controllers
{
    public class AlunoController : Controller
    {
        private readonly ILogger<AlunoController> _logger;

        public static List<Aluno> ListaDeAlunos = new List<Aluno>
        {
            new Aluno{ id = 1, Nome ="Diogo", Idade = 16, Turma = "2A", Cpf = "469.959.440-97"},
            new Aluno{ id = 2, Nome ="Anakin", Idade = 44, Turma = "2B", Cpf = "467.968.423-84"},
            new Aluno{ id = 3, Nome ="Obi-Wan", Idade = 54, Turma = "3A", Cpf = "756.509.234-84"}

        };

        public IActionResult ListarAlunos()
        {
            ViewBag.Aluno = ListaDeAlunos;

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarAluno(Aluno aluno)
        {
            aluno.id = ListaDeAlunos.Max(f => f.id) + 1;

            ListaDeAlunos.Add(aluno);

            return RedirectToAction(nameof(ListarAlunos));

        }


        public AlunoController(ILogger<AlunoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}