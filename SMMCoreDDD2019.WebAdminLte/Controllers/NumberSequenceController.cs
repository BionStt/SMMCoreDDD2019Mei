using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SMMCoreDDD2019.WebAdminLte.Controllers
{
    public class NumberSequenceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}