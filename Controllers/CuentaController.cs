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
    public class CuentaController : Controller
    {
        private readonly ILogger<CuentaController> _logger;

        public CuentaController(ILogger<CuentaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Registrar()
        {
            return View();
        }

        public IActionResult Login()
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