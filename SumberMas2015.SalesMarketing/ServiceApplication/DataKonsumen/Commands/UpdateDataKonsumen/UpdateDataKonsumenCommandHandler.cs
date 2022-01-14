using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataKonsumen.Commands.UpdateDataKonsumen
{
    public class UpdateDataKonsumenCommandHandler : IRequestHandler<UpdateDataKonsumenCommand>
    { 
        private readonly SalesMarketingContext _context;

        public UpdateDataKonsumenCommandHandler(SalesMarketingContext context)
        {
            _context=context;
        }

        public async Task<Unit> Handle(UpdateDataKonsumenCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataKonsumen.Where(x=>x.NoUrutId==request.CustomerID).SingleOrDefaultAsync();
          
            if (entity == null)
            {
                throw new ArgumentNullException("Data Konsumen tidak tersedia");
            }
            entity.SetEmail(request.Email);
            entity.SetNama(request.NamaDepan,request.NamaBelakang,request.NamaDepanBPKB,request.NamaBelakangBPKB);
            entity.SetAlamatKirim(request.JalanKirim, request.KelurahanKirim, request.KecamatanKirim, request.KotaKirim, request.PropinsiKirim, request.KodePosKirim, request.NoTeleponKirim,request.NoFaxKirim,request.NoHandphoneKirim);
            entity.SetAlamatTinggal(request.Jalan, request.Kelurahan, request.Kecamatan, request.Kota, request.Propinsi, request.KodePos, request.NoTelepon, request.NoFax, request.NoHandphone);
            entity.SetBidangPekerjaan(Guid.Parse(request.KodeBidangPekerjaan),request.NamaBidangPekerjaan);
            entity.SetBidangUsaha(Guid.Parse(request.KodeBidangUsaha), request.NamaBidangUsaha);
           // entity.SetUserNameId(request.UserInput, request.UserIDPeg);

           
            _context.DataKonsumen.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
