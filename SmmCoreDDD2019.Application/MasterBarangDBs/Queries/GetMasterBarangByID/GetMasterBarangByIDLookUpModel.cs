using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.MasterBarangDBs.Queries.GetMasterBarangByID
{
    public class GetMasterBarangByIDLookUpModel : IHaveCustomMapping
    {
        //  public int NoUrutKendaraan { get; set; }
        public string NoUrutTypeKendaraan { get; set; }
        public string Aktif { get; set; }
        public decimal? BBN { get; set; }
        public string Cc { get; set; }
        public decimal Harga { get; set; }
        public string Merek { get; set; }
        public string NamaBarang { get; set; }
        public string NomorRangka { get; set; }
        public string NomorMesin { get; set; }
        public int? Tahun { get; set; }
        public string Tipe { get; set; }
        public string TypeKendaraan { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<MasterBarangDB, GetMasterBarangByIDLookUpModel>()
             .ForMember(cDTO => cDTO.Aktif, opt => opt.MapFrom(c => c.Aktif))
            .ForMember(cDTO => cDTO.BBN, opt => opt.MapFrom(c => c.BBN))
              .ForMember(cDTO => cDTO.Cc, opt => opt.MapFrom(c => c.Cc))
            .ForMember(cDTO => cDTO.Harga, opt => opt.MapFrom(c => c.Harga))
              .ForMember(cDTO => cDTO.Merek, opt => opt.MapFrom(c => c.Merek))
            .ForMember(cDTO => cDTO.NamaBarang, opt => opt.MapFrom(c => c.NamaBarang))
              .ForMember(cDTO => cDTO.NomorRangka, opt => opt.MapFrom(c => c.NomorRangka))
            .ForMember(cDTO => cDTO.NomorMesin, opt => opt.MapFrom(c => c.NomorMesin))
                     .ForMember(cDTO => cDTO.Tahun, opt => opt.MapFrom(c => c.Tahun))
              .ForMember(cDTO => cDTO.Tipe, opt => opt.MapFrom(c => c.Tipe))
            .ForMember(cDTO => cDTO.TypeKendaraan, opt => opt.MapFrom(c => c.TypeKendaraan));
            // .ForMember(cDTO => cDTO.NamaBarang, opt => opt.MapFrom(c => string.Format("{0} - {1} - {2:c}", c.NamaBarang, c.Merek, (c.Harga + c.BBN))));


        }
    }
}
