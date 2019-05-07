using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmmCoreDDD2019.Common.Services;
using SMMCoreDDD2019.WebUI.Models;
using Microsoft.Extensions.Localization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace SMMCoreDDD2019.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;

        private readonly ILogger _logger;
        public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            ViewBag.Title = _localizer["About Title"];

            _logger.LogInformation(LoggingEvents.ListItems, "Listing Home Index");
            return RedirectToAction("UserProfile", "UserRole");
            // return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
        [Authorize]
        public IActionResult About()
        {
            _logger.LogInformation(LoggingEvents.ListItems, "Listing Home About");

            ViewData["Message"] = "Your application description page.";
            ViewBag.Message = _localizer["Your application description page."];
            return View();
        }

        [Authorize]
        public IActionResult Contact()
        {
            _logger.LogInformation(LoggingEvents.ListItems, "Listing Home Contact");

            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
