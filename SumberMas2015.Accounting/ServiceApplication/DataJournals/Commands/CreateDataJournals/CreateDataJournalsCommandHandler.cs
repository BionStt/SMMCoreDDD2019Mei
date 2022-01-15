using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.Accounting.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.ServiceApplication.DataJournals.Commands.CreateDataJournals
{
    public class CreateDataJournalsCommandHandler : IRequestHandler<CreateDataJournalsCommand, Guid>
    {
        private readonly AccountingDbContext _dbContext;

        public CreateDataJournalsCommandHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateDataJournalsCommand request, CancellationToken cancellationToken)
        {
            var xx = await _dbContext.DataJournalHeaders.OrderByDescending(x => x.NoUrutId).Take(1).ToListAsync();
            var xy = string.Empty;

            if (xx.Any())
            {
                xy = (xx[0].NoUrutId + 1).ToString();
            }
            else
            {
                xy = "1";

            }
            //if (xx.NoUrutId >= 1)
            //{
            //    xy = xx.NoUrutId.ToString();
            //}
            //else
            //{
            //    xy = "1";
            //}

            var entity = Domain.DataJournalHeader.CreateDataJournalHeader(request.TanggalInput, request.Keterangan, request.TipeJournalId, request.UserInput, GenerateNBJ(request.TanggalInput, xy), request.TotalRupiah);

            await _dbContext.DataJournalHeaders.AddAsync(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return entity.DataJournalHeaderId;
        }

        private string GenerateNBJ(DateTime TanggalInput, string Number)
        {
            var bln = TanggalInput.Month;
            var thn = TanggalInput.Year;
            var NoBuktiJurnal = string.Empty;

            switch (bln)
            {
                case 1:
                    NoBuktiJurnal = "NBJ/" + Number + "/I/" + thn;
                    break;
                case 2:
                    NoBuktiJurnal = "NBJ/" + Number + "/II/" + thn;
                    break;
                case 3:
                    NoBuktiJurnal = "NBJ/" + Number + "/III/" + thn;
                    break;
                case 4:
                    NoBuktiJurnal = "NBJ/" + Number + "/IV/" + thn;
                    break;
                case 5:
                    NoBuktiJurnal = "NBJ/" + Number + "/V/" + thn;
                    break;
                case 6:
                    NoBuktiJurnal = "NBJ/" + Number + "/VI/" + thn;
                    break;
                case 7:
                    NoBuktiJurnal = "NBJ/" + Number + "/VII/" + thn;
                    break;
                case 8:
                    NoBuktiJurnal = "NBJ/" + Number + "/VIII/" + thn;
                    break;
                case 9:
                    NoBuktiJurnal = "NBJ/" + Number + "/IX/" + thn;
                    break;
                case 10:
                    NoBuktiJurnal = "NBJ/" + Number + "/X/" + thn;
                    break;
                case 11:
                    NoBuktiJurnal = "NBJ/" + Number + "/XI/" + thn;
                    break;
                case 12:
                    NoBuktiJurnal = "NBJ/" + Number + "/XII/" + thn;
                    break;
            }
            return NoBuktiJurnal;
        }

    }
}
