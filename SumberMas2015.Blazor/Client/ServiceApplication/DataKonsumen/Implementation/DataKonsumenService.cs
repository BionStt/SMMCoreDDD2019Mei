using SumberMas2015.Blazor.Client.ServiceApplication.DataKonsumen.Contracts;
using SumberMas2015.Blazor.Shared.Dto.Agama;
using SumberMas2015.Blazor.Shared.Dto.DataKonsumen;
using SumberMas2015.Blazor.Shared.Dto.JenisKelamin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Blazor.Client.ServiceApplication.DataKonsumen.Implementation
{
    public class DataKonsumenService: IDataKonsumenService
    {
        private readonly HttpClient http;

        private const string DataKonsumenPath = "api/DataKonsumen";
        private const string DataKonsumenPathWithSlash = DataKonsumenPath + "/";
        private const string JenisKelaminPath = "api/DataKonsumen/GetJenisKelamin";
        private const string AgamaPath = "api/DataKonsumen/GetListAgama";

        public DataKonsumenService(HttpClient http)
        {
            this.http=http;
        }

        public async Task<Guid> CreateDataKonsumenAsync(CreateDataKonsumenRequest model)
        {
            var dataKonsumenResponse = await this.http.PostAsJsonAsync(DataKonsumenPath, model);
            var dataKonsumenId = await dataKonsumenResponse.Content.ReadFromJsonAsync<Guid>();

            //apakah code dibawahberfungsi ?
            var dataKonsumenIdString = await dataKonsumenResponse.Content.ReadAsStringAsync();

            if (!dataKonsumenResponse.IsSuccessStatusCode)
            {
                throw new ApplicationException(dataKonsumenIdString);
            }
            return dataKonsumenId;
        }

        public async Task<IReadOnlyCollection<ListJenisKelaminResponse>> GetJenisKelamin()
        {
            var JnsKelamin = await this.http.GetFromJsonAsync<IReadOnlyCollection<ListJenisKelaminResponse>>(JenisKelaminPath);
            return JnsKelamin;
        }

        public async Task<IReadOnlyCollection<AgamaListResponse>> GetAgama()
        {
            var listAgama = await this.http.GetFromJsonAsync<IReadOnlyCollection<AgamaListResponse>>(AgamaPath);
            return listAgama;
        }
    }
}
