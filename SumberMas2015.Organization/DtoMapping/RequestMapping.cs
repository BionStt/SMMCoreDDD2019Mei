using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumberMas2015.Organization.Dto.DataPerusahaan;
using SumberMas2015.Organization.Dto.DataPerusahaanCabang;
using SumberMas2015.Organization.ServiceApplication.DataPerusahaan.Commands.CreateDataPerusahaan;
using SumberMas2015.Organization.ServiceApplication.DataPerusahaanCabang.Commands.CreateDataPerusahaanCabang;

namespace SumberMas2015.Organization.DtoMapping
{
    public static class RequestMapping
    {
        public static CreateDataPerusahaanCabangCommand ToCommand(this CreateDataPerusahaanCabangRequest model )
        {
            return new CreateDataPerusahaanCabangCommand { 
            DataPerusahaanId  = model.DataPerusahaanId,
            NamaPerusahaanCabang = model.NamaPerusahaanCabang,
            PenanggungJawab = model.PenanggungJawab,
            AlamatPerusahaanCabang = Domain.ValueObjects.Alamat.CreateAlamat(model.Jalan, model.Kelurahan, model.Kecamatan, model.Kota, model.Propinsi,
              model.KodePos, model.NomorTelepon, model.NomorFaks, model.NomorHandphone)


            };
        }

        public static CreateDataPerusahaanCommand ToCommand(this CreateDataPerusahaanRequest model)
        {
            return new CreateDataPerusahaanCommand
            {
              NamaPerusahaan = model.NamaPerusahaan,
              PenanggungJawab = model.PenanggungJawab,
              AlamatPerusahaan = Domain.ValueObjects.Alamat.CreateAlamat(model.Jalan,model.Kelurahan,model.Kecamatan,model.Kota,model.Propinsi,
              model.KodePos,model.NomorTelepon,model.NomorFaks,model.NomorHandphone)





            };
        }
    }
}
