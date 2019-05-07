using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.PembelianDetails.Query.GetKodeBeliDetail
{
    public class GetKodeBeliDetailQuery : IRequest<GetKodeBeliDetailViewModel>
    {
        public string Id { get; set; }
    }
}
