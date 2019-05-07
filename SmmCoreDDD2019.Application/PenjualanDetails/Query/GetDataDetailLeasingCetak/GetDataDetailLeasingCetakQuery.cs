using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataDetailLeasingCetak
{
    public class GetDataDetailLeasingCetakQuery : IRequest<GetDataDetailLeasingCetakViewModel>
    {
    public string Id { get; set; }
    }
}
