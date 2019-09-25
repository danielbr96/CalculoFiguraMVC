using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculoCirculo.Models;

namespace CalculoFiguraMVC.Controllers
{
    public class perimetroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Mensaje(string igual)
        {
            return "radio = 45, diametro = radio*2, perimetro = pi*diametro = 282.744" + igual;
        }

    }
}