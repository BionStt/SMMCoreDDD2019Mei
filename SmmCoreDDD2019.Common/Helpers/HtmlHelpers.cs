using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.IO;


namespace SmmCoreDDD2019.Common.Helpers
{
    public static class HtmlHelpers
    {
        public static string IsSelected(this IHtmlHelper html, string controller = null, string action = null, string cssClass = null)
        {
            if (String.IsNullOrEmpty(cssClass))
                cssClass = "active";

            string currentAction = (string)html.ViewContext.RouteData.Values["action"];
            string currentController = (string)html.ViewContext.RouteData.Values["controller"];

            if (String.IsNullOrEmpty(controller))
                controller = currentController;

            if (String.IsNullOrEmpty(action))
                action = currentAction;

            return controller == currentController && action == currentAction ?
                cssClass : String.Empty;
        }

        public static string PageClass(this IHtmlHelper htmlHelper)
        {
            string currentAction = (string)htmlHelper.ViewContext.RouteData.Values["action"];
            return currentAction;
        }

        public static string IsSelected(this IHtmlHelper html, string actions = null)
        {
            var cssClass = "active";


            string currentAction = (string)html.ViewContext.RouteData.Values["action"];
            string[] actionarr = !String.IsNullOrEmpty(actions) ? actions.Split(',') : new string[] { };


            bool result = (actionarr.Contains<string>(currentAction));



            return result ?
                cssClass : String.Empty;
        }

        public static bool IsMenuActive(this IHtmlHelper htmlHelper, string menuItemUrl)
        {
            var viewContext = htmlHelper.ViewContext;
            var currentPageUrl = viewContext.ViewData["ActiveMenu"] as string ?? viewContext.HttpContext.Request.Path;
            return currentPageUrl.StartsWith(menuItemUrl, StringComparison.OrdinalIgnoreCase);
        }

    }
}
