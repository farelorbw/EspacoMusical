using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using espacomusical.Models;

namespace espacomusical.Controllers
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
            UsuarioRepository ur = new UsuarioRepository();
            ur.TestarConexao();
            return View();
        }
        public IActionResult Produtos()
        {
            return View();
        }
      
      public IActionResult Cordas()
        {
            return View();
        }
      public IActionResult Capas()
        {
            return View();
        }
         public IActionResult Outros()
        {
            return View();
        }
        public IActionResult Percussao()
        {
            return View();
        }
        public IActionResult Sopro()
        {
            return View();
        }
         public IActionResult Suportes()
        {
            return View();
        }
         public IActionResult Teclas()
        {
            return View();
        }
        public IActionResult Privacidade()
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




