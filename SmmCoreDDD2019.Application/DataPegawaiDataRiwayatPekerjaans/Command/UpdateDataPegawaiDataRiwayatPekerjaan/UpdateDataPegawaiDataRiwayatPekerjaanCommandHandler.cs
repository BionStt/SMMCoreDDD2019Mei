﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Application.Interfaces;
namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPekerjaans.Command.UpdateDataPegawaiDataRiwayatPekerjaan
{
    public class UpdateDataPegawaiDataRiwayatPekerjaanCommandHandler:IRequestHandler<UpdateDataPegawaiDataRiwayatPekerjaanCommand,Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public UpdateDataPegawaiDataRiwayatPekerjaanCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateDataPegawaiDataRiwayatPekerjaanCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataPegawaiDataRiwayatPekerjaan
             .SingleAsync(c => c.Id == request.IDPegawai, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataPegawaiDataRiwayatPekerjaan), request.IDPegawai);
            }

          //  entity.NoUrut = request.NoUrut;
            entity.DataPegawaiId = request.IDPegawai;
            entity.NamaPerusahaan= request.NamaPerusahaan;
            entity.AlamatP= request.AlamatP;
            entity.KelurahanP = request.KelurahanP;
            entity.KecamatanP = request.KecamatanP;
            entity.KotaP = request.KotaP;
            entity.KodePosP= request.KodePosP;
            entity.TelpP= request.TelpP;
            entity.JabatanAwal= request.JabatanAwal;
            entity.JabatanAkhir= request.JabatanAkhir;
            entity.MulaiBekerja = request.MulaiBekerja;
            entity.AkhirBekerja= request.AkhirBekerja;
            entity.GajiTerakhir= request.GajiTerakhir;
            entity.AtasanP= request.AtasanP;
            entity.TglInput= request.TglInput;
            entity.Keterangan= request.Keterangan;


            _context.DataPegawaiDataRiwayatPekerjaan.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;


            //  throw new NotImplementedException();
        }
    }
}
