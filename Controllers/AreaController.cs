using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculoCirculo.Models;

namespace CalculoFiguraMVC.Controllers
{
    public class AreaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

      public String AreaCirculo()
        {
            int r = 5;
            //area de un circulo
             double area = (Math.PI * Math.Pow(r, 2)); 
            String resultado=Convert.ToString("El area del circulo es de " + area);
            return resultado;
        }

    }
}