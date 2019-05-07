using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.MasterBarangDBs.Queries.GetNamaBarangQr
{
    public class GetNamaBarangQrLookUpModel : IHaveCustomMapping
    {
        public int NoUrutKendaraan { get; set; }
        public string NamaBarang { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<MasterBarangDB, GetNamaBarangQrLookUpModel>()
             .ForMember(cDTO => cDTO.NoUrutKendaraan, opt => opt.MapFrom(c => c.NoUrutTypeKendaraan))
            // .ForMember(cDTO => cDTO.NamaBarang, opt => opt.MapFrom(c => c.NamaBarang));
            .ForMember(cDTO => cDTO.NamaBarang, opt => opt.MapFrom(c=>string.Format("{0} - {1} - {2:c}", c.NamaBarang, c.Merek,(c.Harga+c.BBN))));
                                                           

        }
    }
}
