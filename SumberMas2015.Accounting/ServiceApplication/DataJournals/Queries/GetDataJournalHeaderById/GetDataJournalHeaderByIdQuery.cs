using MediatR;
using SumberMas2015.Accounting.ServiceApplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.ServiceApplication.DataJournals.Queries.GetDataJournalHeaderById
{
    public class GetDataJournalHeaderByIdQuery : IRequest<GetDataJournalHeaderByIdResponse>
    {
        public Guid KodeJournalHeaderId { get; set; }

    }
}
