using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.ServiceApplication.DataJournalDetails.Commands.CreateSaldoAwal
{
    public class CreateSaldoAwalCommand : IRequest<Guid>
    {
        public decimal Debit { get; set; }
        public decimal Kredit { get; set; }
        public Guid DataAccountId { get; set; }
    }
}
