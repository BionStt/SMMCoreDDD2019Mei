using MediatR;
using SumberMas2015.Accounting.ServiceApplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.ServiceApplication.DataJournalDetails.Queries.ListDataJournalDetailsByAkun
{
    public class ListDataJournalDetailsByAkunQuery : IRequest<IReadOnlyCollection<ListDataJournalDetailsByAkunResponse>>
    {
        public string NoUrutId { get; set; }
    }
}
