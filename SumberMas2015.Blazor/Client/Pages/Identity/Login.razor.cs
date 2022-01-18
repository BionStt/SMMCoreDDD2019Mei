using SumberMas2015.Blazor.Shared.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Blazor.Client.Pages.Identity
{
    public partial class Login
    {
        LoginParameters loginParameters { get; set; } = new LoginParameters();
        string error { get; set; }

        async Task OnSubmit()
        {
            error = null;
            try
            {
                await authStateProvider.Login(loginParameters);
                navigationManager.NavigateTo("");
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
        }

    }
}
