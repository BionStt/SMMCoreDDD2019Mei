using MediatR;
using SumberMas2015.Accounting.ServiceApplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.ServiceApplication.DataJournals.Queries.GetLaporanNeraca2
{
    public class GetLaporanNeraca2Query : IRequest<IReadOnlyCollection<GetLaporanNeraca2Response>>
    {
        public DateTime Tanggal1 { get; set; }
        public DateTime Tanggal2 { get; set; }
    }
}
