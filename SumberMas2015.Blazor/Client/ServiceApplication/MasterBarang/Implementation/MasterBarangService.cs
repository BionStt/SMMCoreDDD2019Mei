using SumberMas2015.Blazor.Client.ServiceApplication.MasterBarang.Contracts;
using SumberMas2015.Blazor.Shared.Dto.MasterBarang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Blazor.Client.ServiceApplication.MasterBarang.Implementation
{
    public class MasterBarangService : IMasterBarangService
    {
        private readonly HttpClient http;

        private const string MasterBarangPath = "api/MasterBarang";
        private const string MasterBarangPathWithSlash = MasterBarangPath + "/";
        private const string MerekPath = "api/MasterBarang/GetMerek";

        public MasterBarangService(HttpClient http)
        {
            this.http=http;
        }

        public async Task<Guid> CreateMasterBarangAsync(CreateMasterBarangRequest model)
        {
            var dataKonsumenResponse = await this.http.PostAsJsonAsync(MasterBarangPath, model);
            var dataKonsumenId = await dataKonsumenResponse.Content.ReadFromJsonAsync<Guid>();

            return dataKonsumenId;
           
        }
    }
}
