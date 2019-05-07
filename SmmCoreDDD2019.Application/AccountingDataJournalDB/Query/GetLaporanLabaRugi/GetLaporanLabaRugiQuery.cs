using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetLaporanLabaRugi
{
    public class GetLaporanLabaRugiQuery : IRequest<GetLaporanLabaRugiViewModel>
    {
        public DateTime Tanggal1 { get; set; }
        public DateTime Tanggal2 { get; set; }
    }
}
