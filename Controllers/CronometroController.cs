using Microsoft.AspNetCore.Mvc;
using Cronometro.Models;

namespace Cronometro.Controllers
{
        public class CronometroController : Controller
        {
            public IActionResult Index()
            {
                return View("~/Views/Home/Index.cshtml", new Cronometro.Models.Cronometro());
            }
    }
}
