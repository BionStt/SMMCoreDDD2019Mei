using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Microsoft.AspNetCore.Mvc.RazorPages
{
    public static class PageModelExtensions
    {
        public static void SetStatusMessage(this PageModel pageModel, string message)
        {
            pageModel.TempData["StatusMessage"] = message;
        }
    }
}
