using SumberMas2015.SalesMarketing.Dto.DataKonsumen;
using SumberMas2015.SalesMarketing.ServiceApplication.DataKonsumen.Commands.CreateDataKonsumen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.DtoMapping
{
    public static class DataKonsumenRequestMapping
    {
        public static CreateDataKonsumenCommand ToCommand(this CreateDataKonsumenRequest model )
        {
            return new CreateDataKonsumenCommand
            {
                Nama = Domain.ValueObjects.Name.CreateName(model.NamaDepan, model.NamaBelakang),
                Alamat = Domain.ValueObjects.Alamat.CreateAlamat(model.Jalan,model.Kelurahan,model.Kecamatan,
                model.Kota,model.Propinsi,model.KodePos,model.NomorTelepon,model.NomorFaks,model.NomorHandphone),
                JenisKelamin = model.JenisKelamin,
                AlamatKirim = Domain.ValueObjects.Alamat.CreateAlamat(model.JalanKirim, model.KelurahanKirim, model.KecamatanKirim,
                model.KotaKirim, model.PropinsiKirim, model.KodePosKirim, model.NomorTeleponKirim, model.NomorFaksKirim, model.NomorHandphoneKirim),
                NamaBPKB = Domain.ValueObjects.Name.CreateName(model.NamaDepanBPKB, model.NamaBelakangBPKB),
                NoKtp = model.NomorKtp,
                Agama = model.Agama,
                TanggalLahir = model.TangggalLahir,
                KodeBidangPekerjaan = model.KodeBidangPekerjaan,
                NamaBidangPekerjaan = model.NamaBidangPekerjaan,
                KodeBidangUsaha = model.KodeBidangUsaha,
                NamaBidangUsaha = model.NamaBidangUsaha,
                Email = model.Email,
                UserIDPeg = model.UserIDPeg,
                UserInput = model.UserInput



            };
        }
    }
}
