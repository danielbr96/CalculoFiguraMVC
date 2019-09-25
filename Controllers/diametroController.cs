using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculoCirculo.Models;

namespace CalculoCirculo.Controllers
{
    public class diametroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public String diametro()
        {
            return "Dado el Radio 5 el diametro es 10";
                    }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
