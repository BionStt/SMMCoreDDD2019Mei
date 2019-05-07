using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataPiutangLeasing
{
    public class GetDataPiutangLeasingQuery : IRequest<GetDataPiutangLeasingViewModel>
    {
        public string IdLeasing { get; set; }
    }
}
