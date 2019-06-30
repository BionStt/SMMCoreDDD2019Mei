using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.StokUnits.Query.GetLaporanSO
{
    public class GetLaporanSOLookUpModel : IHaveCustomMapping
    {

        public int NoUrutSO { get; set; }
        public string TypeKendaraan { get; set; }
        public string NamaBarang1 { get; set; }
        public string Merek1 { get; set; }
        public string NoRangka { get; set; }
        public string NoMesin { get; set; }
        public string Warna{ get; set; }
        public DateTime TanggalBeli { get; set; }
        public string NamaSupplier { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<StokUnit, GetLaporanSOLookUpModel>()
             .ForMember(cDTO => cDTO.NoUrutSO, opt => opt.MapFrom(c => c.Id));
            // .ForMember(cDTO => cDTO.NamaBarang, opt => opt.MapFrom(c => c.NamaBarang));
            // .ForMember(cDTO => cDTO.NamaBarang, opt => opt.MapFrom(c => string.Format("{0} - {1:d} - {2}", c.KodeBeli, c.TglBeli, c.Idsupplier)));


        }
    }
}
