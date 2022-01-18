using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumberMas2015.Blazor.Shared.Dto.MasterBarang;
using SumberMas2015.Blazor.Client.Shared;
using SumberMas2015.Blazor.Client.ServiceApplication.MasterBarang;

namespace SumberMas2015.Blazor.Client.Pages.MasterBarang
{
    public partial class CreateMasterBarang
    {

        private readonly CreateMasterBarangRequest _item = new CreateMasterBarangRequest();

        private SuccessNotification _notification;

       // private IReadOnlyCollection<CreateMerekResponse> _merek;
        protected async override Task OnInitializedAsync()
        {
           // _merek = await this.MasterBarangService.GetMerek();
        }

        private async Task Create_Click()
        {
            var id = await MasterBarangService.CreateMasterBarangAsync(_item);
           
            _notification.Show();//dicek ya
            
            this.NavigationManager.NavigateTo("/", forceLoad: true);
        }








    }
}
