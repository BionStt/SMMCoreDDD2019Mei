using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.AccountingDataAccountDB.Query.GetDataAccountByParent2
{
    public class GetDataAccountByParent2Query : IRequest<GetDataAccountByParent2ViewModel>
    {
        public string Id { get; set; }
    }
}
