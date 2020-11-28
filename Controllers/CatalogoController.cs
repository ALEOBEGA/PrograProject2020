using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrograProject2020.Models;

namespace PrograProject2020.Controllers
{
    public class CatalogoController : Controller
    {
        private readonly ILogger<CatalogoController> _logger;

        public CatalogoController(ILogger<CatalogoController> logger)
        {
            _logger = logger;
        }

        public IActionResult CatalogoHombre()
        {
            return View();
        }

        public IActionResult CatalogoMujer()
        {
            return View();
        }
         public IActionResult CatalogoNina()
        {
            return View();
        }
        public IActionResult CatalogoNino()
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
