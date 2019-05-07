using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.StokUnits.Query.GetDataSOByID
{
    public class GetDataSOByIDQuery : IRequest<GetDataSOByIDViewModel>
    {
        public string Id { get; set; }
    }
}
