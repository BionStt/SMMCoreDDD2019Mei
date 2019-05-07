using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetLaporanNeraca
{
    public class GetLaporanNeracaQuery : IRequest<GetLaporanNeracaViewModel>
    {
        public DateTime Tanggal1 { get; set; }
        public DateTime Tanggal2 { get; set; }
    }
}
