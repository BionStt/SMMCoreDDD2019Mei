using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;

namespace SumberMas2015.SalesMarketing.ServiceApplication.PermohonanSTNK.Commands.CreatePermohonanSTNK
{
    public class CreatePermohonanSTNKCommandHandler : IRequestHandler<CreatePermohonanSTNKCommand, Guid>
    {
        private readonly SalesMarketingContext _context;

        public CreatePermohonanSTNKCommandHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreatePermohonanSTNKCommand request, CancellationToken cancellationToken)
        {
            var dtPermohonanSTNK = Domain.PermohonanSTNK.CreatePermohonanSTNK(request.TanggalBayarSTNK, request.NoUrutFaktur, request.NoStnk, request.PajakStnk,
                request.Birojasa, request.BiayaTambahan, request.FormA, request.NomorPlat, request.Perwil, request.PajakProgresif, request.BbnPabrik, request.ProgresifKe);


            await _context.PermohonanSTNK.AddAsync(dtPermohonanSTNK);
            await _context.SaveChangesAsync();

            return dtPermohonanSTNK.PermohonanSTNKId;
        }
    }
}
