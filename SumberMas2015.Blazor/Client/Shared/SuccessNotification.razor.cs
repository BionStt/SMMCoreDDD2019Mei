using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace SumberMas2015.Blazor.Client.Shared
{
    public partial class SuccessNotification
    {
        private string _modalDisplay;
        private string _modalClass;
        private bool _showBackdrop;

        [Inject]
         public NavigationManager Navigation { get; set; }

        public void Show()
        {
            _modalDisplay = "block;";
            _modalClass = "show";
            StateHasChanged();
        }
        private void Hide()
        {
            _modalDisplay="none;";
            _modalClass = "";
            _showBackdrop=false;
            StateHasChanged();
            Navigation.NavigateTo("/products"); // mau kemanan ini ???
        }

    }
}
