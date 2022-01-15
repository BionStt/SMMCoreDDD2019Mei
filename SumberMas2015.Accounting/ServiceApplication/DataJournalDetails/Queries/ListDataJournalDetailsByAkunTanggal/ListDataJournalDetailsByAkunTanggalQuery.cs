using MediatR;
using SumberMas2015.Accounting.ServiceApplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.ServiceApplication.DataJournalDetails.Queries.ListDataJournalDetailsByAkunTanggal
{
    public class ListDataJournalDetailsByAkunTanggalQuery : IRequest<IReadOnlyCollection<ListDataJournalDetailsByAkunTanggalResponse>>
    {
        public string NoUrutId { get; set; }
        public DateTime PeriodeAwal { get; set; }
        public DateTime PeriodeAkhir { get; set; }
    }
}
