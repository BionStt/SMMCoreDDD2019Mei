using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.DataPerusahaanOrgChartDB.Query.GetOrgChartByParent2
{
    public class GetOrgChartByParent2Query : IRequest<GetOrgChartByParent2ViewModel>
    {
        public string Id { get; set; }
    }
}
