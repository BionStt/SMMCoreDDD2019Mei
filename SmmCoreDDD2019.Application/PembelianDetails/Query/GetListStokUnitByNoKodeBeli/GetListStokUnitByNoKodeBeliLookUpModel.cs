using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.PembelianDetails.Query.GetListStokUnitByNoKodeBeli
{
    public class GetListStokUnitByNoKodeBeliLookUpModel : IHaveCustomMapping
    {
        public int NoUrutSO { get; set; }
        public string NamaBarang1 { get; set; }
        public string NoRangka1 { get; set; }
        public string NoMesin1 { get; set; }
        public string Warna1 { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<StokUnit, GetListStokUnitByNoKodeBeliLookUpModel>()
             .ForMember(cDTO => cDTO.NoUrutSO, opt => opt.MapFrom(c => c.Id));
            // .ForMember(cDTO => cDTO.NamaBarang, opt => opt.MapFrom(c => c.NamaBarang));
            // .ForMember(cDTO => cDTO.NamaPembelian, opt => opt.MapFrom(c => string.Format("{0} - {1:d} - {2}", c.KodeBeli, c.TglBeli, c.Idsupplier)));

        }
    }
}
