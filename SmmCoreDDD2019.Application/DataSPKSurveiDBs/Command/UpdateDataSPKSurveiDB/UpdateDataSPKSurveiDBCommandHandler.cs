using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace SmmCoreDDD2019.Application.DataSPKSurveiDBs.Command.UpdateDataSPKSurveiDB
{
    public class UpdateDataSPKSurveiDBCommandHandler : IRequestHandler<UpdateDataSPKSurveiDBCommand, Unit>
    {

        private readonly ISMMCoreDDD2019DbContext _context;

        public UpdateDataSPKSurveiDBCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateDataSPKSurveiDBCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataSPKSurveiDB
                 .SingleAsync(c => c.Id == request.NoUrut, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataSPKSurveiDB), request.NoUrut);
            }
            
                //   entity.NoUrut = request.NoUrut;
                entity.AlamatPemesan = request.AlamatPemesan;
                entity.HandphonePemesan = request.HandphonePemesan;
                entity.KecamatanPemesan = request.KecamatanPemesan;
                entity.KelurahanPemesan = request.KelurahanPemesan;
                entity.KodePosPemesan = request.KodePosPemesan;

                entity.NamaNPWP = request.NamaNPWP;

                entity.NamaPemesan = request.NamaPemesan;
                entity.NoKtpPemesan = request.NoKtpPemesan;
                entity.NoNPWP = request.NoNPWP;
                entity.DataSPKBaruDBId = request.NoUrutSPKBaru;
                entity.PekerjaanPemesan = request.PekerjaanPemesan;
                entity.PropinsiPemesan = request.PropinsiPemesan;

                entity.TelpPemesan = request.TelpPemesan;


            _context.DataSPKSurveiDB.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
            // throw new NotImplementedException();
        }
    }
}
