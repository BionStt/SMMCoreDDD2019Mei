using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataPiutangLeasingMerek
{
    public class GetDataPiutangLeasingMerekQuery :IRequest<GetDataPiutangLeasingMerekViewModel>
    {
         public string IdLeasing { get; set; }
          public string Merek { get; set; }
    }
}
