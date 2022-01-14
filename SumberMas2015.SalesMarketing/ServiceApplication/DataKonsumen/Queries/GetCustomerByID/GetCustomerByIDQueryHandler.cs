using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.SalesMarketing.Dto.DataKonsumen;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataKonsumen.Queries.GetCustomerByID
{
    public class GetCustomerByIDQueryHandler : IRequestHandler<GetCustomerByIDQuery, GetCustomerByIDResponse>
    {
        private readonly SalesMarketingContext _context;

        public GetCustomerByIDQueryHandler(SalesMarketingContext context)
        {
            _context=context;
        }

        public async Task<GetCustomerByIDResponse> Handle(GetCustomerByIDQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.DataKonsumen.Where(x=>x.NoUrutId.ToString() == request.Id).Select(x=> new GetCustomerByIDResponse
            { 
            CustomerID = x.NoUrutId,
            Email = x.Email,    
            Jalan = x.AlamatTinggal.Jalan,
            JalanKirim = x.AlamatKirim.Jalan,
            Kecamatan = x.AlamatTinggal.Kecamatan,
            KecamatanKirim = x.AlamatKirim.Kecamatan,
            Kelurahan = x.AlamatTinggal.Kelurahan,
            KelurahanKirim = x.AlamatKirim.Kelurahan,
            KodePos = x.AlamatTinggal.KodePos,
            KodePosKirim = x.AlamatKirim.KodePos,
            Kota = x.AlamatTinggal.Kota,
            KotaKirim =x.AlamatKirim.Kota,
            Nama = String.Format("{0} {1}",x.Nama.NamaDepan,x.Nama.NamaBelakang),
            NamaBPKB = String.Format("{0} {1}", x.NamaBPKB.NamaDepan, x.NamaBPKB.NamaBelakang),
            NoFax =x.AlamatTinggal.NoFax,
            NoFaxKirim = x.AlamatKirim.NoFax,
            NoHandphone = x.AlamatTinggal.NoHandphone,
            NoHandphoneKirim = x.AlamatKirim.NoHandphone,
            NoKtp = x.NoKTP,
            NoTelepon = x.AlamatTinggal.NoTelepon,
            NoTeleponKirim = x.AlamatKirim.NoTelepon,
            Propinsi = x.AlamatTinggal.Propinsi,
            PropinsiKirim = x.AlamatKirim.Propinsi,
            TglLahir = x.TanggalLahir,
              KodeBidangPekerjaan = x.KodeBidangPekerjaan.ToString(),
              NamaBidangPekerjaan = x.NamaBidangPekerjaan,
              NamaBidangUsaha = x.NamaBidangUsaha,
              //NoKodeCustomer = x.
              



            }).SingleOrDefaultAsync();


            return returnQuery;
        }
    }
}
