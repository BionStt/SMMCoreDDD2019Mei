using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;

namespace SumberMas2015.SalesMarketing.ServiceApplication.PermohonanBPKB.Commands.CreatePermohonanBPKB
{
    public class CreatePermohonanBPKBCommandHandler : IRequestHandler<CreatePermohonanBPKBCommand, Guid>
    {
        private readonly SalesMarketingContext _context;

        public CreatePermohonanBPKBCommandHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreatePermohonanBPKBCommand request, CancellationToken cancellationToken)
        {
            var permohonanFakturId = await _context.PermohonanFaktur.Where(x => x.NoUrutId == request.NoUrutFaktur).Select(x=>x.PermohonanFakturId).SingleOrDefaultAsync();
            var dtPermohonanBPKB = Domain.PermohonanBPKB.CreatePermohonanBPKB(permohonanFakturId, request.NoBpkb, request.TanggalTerimaBPKB,request.UserName,request.UserNameId);

            await _context.PermohonanBPKB.AddAsync(dtPermohonanBPKB);
            await _context.SaveChangesAsync();

            return dtPermohonanBPKB.PermohonanBPKBId; 


        }
    }
}
