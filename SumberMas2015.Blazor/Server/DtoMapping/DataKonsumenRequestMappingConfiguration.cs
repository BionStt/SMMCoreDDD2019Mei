using SumberMas2015.Blazor.Shared.Dto.DataKonsumen;
using SumberMas2015.SalesMarketing.ServiceApplication.DataKonsumen.Commands.CreateDataKonsumen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumberMas2015.SalesMarketing.Domain.ValueObjects;

namespace SumberMas2015.Blazor.Server.DtoMapping
{
    public static class DataKonsumenRequestMappingConfiguration
    {
        public static CreateDataKonsumenCommand ToCommand(this CreateDataKonsumenRequest model)
        {
            return new CreateDataKonsumenCommand
            {
                Agama = model.Agama,
                Alamat = Alamat.CreateAlamat(model.Jalan, model.Kelurahan, model.Kecamatan, model.Kota, model.Propinsi, model.KodePos, model.NomorTelepon, model.NomorFaks, model.NomorHandphone),
                AlamatKirim  = Alamat.CreateAlamat(model.JalanKirim,model.KelurahanKirim,model.KecamatanKirim,model.KotaKirim,model.PropinsiKirim,model.KodePosKirim,model.NomorTeleponKirim,model.NomorFaksKirim,model.NomorHandphoneKirim),
                Email = model.Email,
                JenisKelamin = model.JenisKelamin,
                KodeBidangPekerjaan = model.KodeBidangPekerjaan,
                KodeBidangUsaha = model.KodeBidangUsaha,
                Nama  =Name.CreateName(model.NamaDepan,model.NamaBelakang),
                NamaBPKB = Name.CreateName(model.NamaDepanBPKB,model.NamaDepanBPKB),
                NamaBidangPekerjaan = model.NamaBidangPekerjaan,
                NamaBidangUsaha = model.NamaBidangUsaha,
                NoKtp = model.NomorKtp,
                TanggalLahir = model.TangggalLahir,
                UserName = model.UserName,
                UserNameId = model.UserNameId
            
            };
        }
    }
}
