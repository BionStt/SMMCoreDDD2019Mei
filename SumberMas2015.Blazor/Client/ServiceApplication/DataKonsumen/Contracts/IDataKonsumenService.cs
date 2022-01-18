using SumberMas2015.Blazor.Shared.Dto.Agama;
using SumberMas2015.Blazor.Shared.Dto.DataKonsumen;
using SumberMas2015.Blazor.Shared.Dto.JenisKelamin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Blazor.Client.ServiceApplication.DataKonsumen.Contracts
{
    public interface IDataKonsumenService
    {
        Task<Guid> CreateDataKonsumenAsync(CreateDataKonsumenRequest model);

        //Task<IReadOnlyCollection<ListDataKonsumenQueryResponse>> ListDataKonsumen();
        Task<IReadOnlyCollection<ListJenisKelaminResponse>> GetJenisKelamin();
        Task<IReadOnlyCollection<AgamaListResponse>> GetAgama();

    }
}
