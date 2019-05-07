using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.PembelianDetails.Query.GetListPembelianDetail
{
    public class GetListPembelianDetailQuery : IRequest<GetListPembelianDetailViewModel>
    {
        public string Id { get; set; }
    }
}
