using System;
using System.Collections.Generic;
using System.Text;

using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Application.Interfaces;
namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPelatihans.Command.UpdateDataPegawaiDataRiwayatPelatihan
{
    public class UpdateDataPegawaiDataRiwayatPelatihanCommandHandler : IRequestHandler<UpdateDataPegawaiDataRiwayatPelatihanCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public UpdateDataPegawaiDataRiwayatPelatihanCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }


        public async Task<Unit> Handle(UpdateDataPegawaiDataRiwayatPelatihanCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataPegawaiDataRiwayatPelatihan
              .SingleAsync(c => c.Id == request.IDPegawai, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataPegawaiDataRiwayatPelatihan), request.IDPegawai);
            }

           // entity.NoUrut = request.NoUrut;
            entity.DataPegawaiId= request.IDPegawai;
            entity.NamaLembaga= request.NamaLembaga;
            entity.AlamatLembaga= request.AlamatLembaga;
            entity.TelpLembaga= request.TelpLembaga;
            entity.LamaKursus = request.LamaKursus;
            entity.DibiayaiOleh = request.DibiayaiOleh;
            entity.BidangPelatihan= request.BidangPelatihan;


            _context.DataPegawaiDataRiwayatPelatihan.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

            //  throw new NotImplementedException();
        }
    }
}
