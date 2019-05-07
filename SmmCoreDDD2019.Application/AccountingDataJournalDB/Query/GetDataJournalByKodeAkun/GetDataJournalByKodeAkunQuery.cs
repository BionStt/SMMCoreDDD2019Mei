using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetDataJournalByKodeAkun
{
    public class GetDataJournalByKodeAkunQuery : IRequest<GetDataJournalByKodeAkunViewModel>
    {
        public string Id { get; set; }
    }
}
