using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
namespace SmmCoreDDD2019.Application.DataSPKBaruDBs.Command.UpdateDataSPKBaruDB
{
    public class UpdateDataSPKBaruDBCommandHandler : IRequestHandler<UpdateDataSPKBaruDBCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;

        public UpdateDataSPKBaruDBCommandHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateDataSPKBaruDBCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataSPKBaruDB
               .SingleAsync(c => c.NoUrutSPKBaru == request.NoUrutSPKBaru, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataSPKBaruDB), request.NoUrutSPKBaru);
            }

          entity.NoUrutSPKBaru = request.NoUrutSPKBaru;
                entity.LokasiSpk = request.LokasiSpk;
                entity.Terinput = request.Terinput;
                entity.TglInput = request.TglInput;
                entity.Tolak = request.Tolak;
                entity.UserIdpeg = request.UserIdpeg;
            entity.UserInput = request.UserInput;

            _context.DataSPKBaruDB.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

            //throw new NotImplementedException();
        }
    }
}
