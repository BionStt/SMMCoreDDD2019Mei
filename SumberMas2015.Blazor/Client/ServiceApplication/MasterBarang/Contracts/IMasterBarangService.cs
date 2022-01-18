using SumberMas2015.Blazor.Shared.Dto.MasterBarang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Blazor.Client.ServiceApplication.MasterBarang.Contracts
{
    public interface IMasterBarangService
    {
        Task<Guid> CreateMasterBarangAsync(CreateMasterBarangRequest model);

       // Task<IReadOnlyCollection<ListMasterBarangQueryResponse>> ListMasterBarang();
        //Task<IReadOnlyCollection<CreateMerekResponse>> GetMerek();

    }
}
