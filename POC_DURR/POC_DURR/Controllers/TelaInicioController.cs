using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC_DURR.Controllers
{
    public class TelaInicioController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult TipoServico()
        {

            return View("Home/Index");
        }
    }
}
