using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevConnect.Controllers
{
    [Route("[controller]")]
    public class Feed : Controller
    {
        private readonly ILogger<Feed> _logger;

        public Feed(ILogger<Feed> logger)
        {
            _logger = logger;
        }

        // GET /Feed
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        // GET /Feed/Error
        [HttpGet("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
