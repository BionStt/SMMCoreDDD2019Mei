using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumberMas2015.Blazor.Shared.Dto.DataKonsumen;
using SumberMas2015.Blazor.Shared.Dto.Agama;
using SumberMas2015.Blazor.Shared.Dto.JenisKelamin;



namespace SumberMas2015.Blazor.Client.Pages.DataKonsumen
{
    public partial class CreateDataKonsumen
    {
        private readonly CreateDataKonsumenRequest _item = new CreateDataKonsumenRequest();
        private IReadOnlyCollection<ListJenisKelaminResponse> _jenisKelamin;
        private IReadOnlyCollection<AgamaListResponse> _agama;

        protected async override Task OnInitializedAsync()
        {
            this._agama = await DataKonsumenService.GetAgama();

            this._jenisKelamin = await this.DataKonsumenService.GetJenisKelamin();

        }

        private async Task Create_Click()
        {
            var id = await DataKonsumenService.CreateDataKonsumenAsync(_item);
            this.NavigationManager.NavigateTo("/", forceLoad: true);

        }



    }
}
