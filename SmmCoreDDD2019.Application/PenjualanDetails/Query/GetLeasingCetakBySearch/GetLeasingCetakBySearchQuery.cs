using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.PenjualanDetails.Query.GetLeasingCetakBySearch
{
    public class GetLeasingCetakBySearchQuery : IRequest<GetLeasingCetakBySearchViewModel>
    {
        public string ID { get; set; }
    }
}
