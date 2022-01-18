using SumberMas2015.Blazor.Shared.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Blazor.Client.Pages.Identity
{
    public partial class Register
    {
        RegisterParameters registerParameters { get; set; } = new RegisterParameters();
        string error { get; set; }

        async Task OnSubmit()
        {
            error = null;
            try
            {
                await authStateProvider.Register(registerParameters);
                navigationManager.NavigateTo("");
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
        }

    }
}
