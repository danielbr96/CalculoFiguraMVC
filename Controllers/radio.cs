using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculoCirculo.Models;

namespace CalculoCirculo.Controllers
{
    public class radioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Mensaje(string igual)
        {
            return "area = 8, radio = sqrt(area/PI) = 1.5957" + igual;
        }

        
    }
}
