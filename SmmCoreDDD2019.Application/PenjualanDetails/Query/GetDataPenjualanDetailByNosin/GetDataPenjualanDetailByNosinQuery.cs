using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR; 

namespace SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataPenjualanDetailByNosin
{
    public class GetDataPenjualanDetailByNosinQuery : IRequest<GetDataPenjualanDetailByNosinViewModel>
    {
        public string Id { get; set; }
    }
}
