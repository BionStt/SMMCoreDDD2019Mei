using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
namespace SmmCoreDDD2019.Application.DataSPKKreditDBs.Command.UpdateDataSPKKreditDB
{
    public class UpdateDataSPKKreditDBCommandHandler : IRequestHandler<UpdateDataSPKKreditDBCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;

        public UpdateDataSPKKreditDBCommandHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateDataSPKKreditDBCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataSPKKreditDB
              .SingleAsync(c => c.NoUrutSPKBaru == request.NoUrutSPKBaru, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataSPKKreditDB), request.NoUrutSPKBaru);
            }

                entity.NoUrut = request.NoUrut;
                entity.BiayaAdministrasiKredit = request.BiayaAdministrasiKredit;
                entity.BiayaAdministrasiTunai = request.BiayaAdministrasiTunai;
                entity.BBN = request.BBN;
                entity.DendaWilayah = request.DendaWilayah;
                entity.DiskonDP = request.DiskonDP;
                entity.DiskonTunai = request.DiskonTunai;
                entity.DPPriceList = request.DPPriceList;
                entity.Komisi = request.Komisi;
                entity.NoUrutSPKBaru = request.NoUrutSPKBaru;
                entity.OffTheRoad = request.OffTheRoad;
                entity.Promosi = request.Promosi;
                entity.UangTandaJadiTunai = request.UangTandaJadiTunai;
                entity.UangTandaJadiKredit = request.UangTandaJadiKredit;

                _context.DataSPKKreditDB.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

            // throw new NotImplementedException();
        }
    }
}
