using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practica1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Controllers
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

        //Importante sin una accion no tenemos vistas
        public IActionResult Suma(Double DatoN1, Double DatoN2)
        {
            if (DatoN1 > 10 || DatoN2 > 10)
            {
                return View("NoMayores");
            }

            Double resultado = DatoN1 + DatoN2;

            ViewBag.DatoN1V = DatoN1;
            ViewBag.DatoN2V = DatoN2;
            ViewBag.VariableAEnviar = resultado;

            return View();
        }

        public IActionResult NoMayores()
        {
            return View();
        }

        public IActionResult Resta(Double DatoN1, Double DatoN2)
        {
            if (DatoN1 > 10 || DatoN2 > 10)
            {
                return View("NoMayores");
            }

            Double resultado = DatoN1 - DatoN2;

            ViewBag.DatoN1V = DatoN1;
            ViewBag.DatoN2V = DatoN2;
            ViewBag.VariableAEnviar = resultado;

            return View();
        }

        public IActionResult Multiplicacion(Double DatoN1, Double DatoN2)
        {
            if (DatoN1 > 10 || DatoN2 > 10)
            {
                return View("NoMayores");
            }

            Double resultado = DatoN1 * DatoN2;

            ViewBag.DatoN1V = DatoN1;
            ViewBag.DatoN2V = DatoN2;
            ViewBag.VariableAEnviar = resultado;

            return View();
        }

        public IActionResult Division(Double DatoN1, Double DatoN2)
        {
            if (DatoN1 > 10 || DatoN2 > 10)
            {
                return View("NoMayores");
            }

            Double resultado = DatoN1 / DatoN2;

            ViewBag.DatoN1V = DatoN1;
            ViewBag.DatoN2V = DatoN2;
            ViewBag.VariableAEnviar = resultado;

            return View();
        }

    }
}
