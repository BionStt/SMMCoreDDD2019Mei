using Microsoft.AspNetCore.Mvc;

namespace SMMCoreDDD2019.AdminLte.Controllers
{
    public class InformationApplication : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
