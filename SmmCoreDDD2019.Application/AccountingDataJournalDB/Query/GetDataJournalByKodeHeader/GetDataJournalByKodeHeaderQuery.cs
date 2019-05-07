using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetDataJournalByKodeHeader
{
    public class GetDataJournalByKodeHeaderQuery : IRequest<GetDataJournalByKodeHeaderViewModel>
    {
        public string Id { get; set; }
    }
}
