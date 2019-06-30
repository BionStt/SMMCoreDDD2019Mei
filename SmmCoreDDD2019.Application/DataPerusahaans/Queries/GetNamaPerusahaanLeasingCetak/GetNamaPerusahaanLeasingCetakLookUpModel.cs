using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.DataPerusahaans.Queries.GetNamaPerusahaanLeasingCetak
{
    public class GetNamaPerusahaanLeasingCetakLookUpModel : IHaveCustomMapping
    {
        public int IDPerusahaan { get; set; }
        public string NamaPerusahaan { get; set; }
        public string AlamatPerusahaan { get; set; }

        public string KelurahanPerusahaan { get; set; }

        public string KecamatanPerusahaan { get; set; }
        public string KotaPerusahaan { get; set; }
        public string PropinsiPerusahaan { get; set; }
        public string KodePos { get; set; }
        public string Telp { get; set; }
        public string Cs { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<DataPerusahaan, GetNamaPerusahaanLeasingCetakLookUpModel>()
             .ForMember(cDTO => cDTO.IDPerusahaan, opt => opt.MapFrom(c => c.Id))
               .ForMember(cDTO => cDTO.NamaPerusahaan, opt => opt.MapFrom(c => c.NamaP))
                 .ForMember(cDTO => cDTO.AlamatPerusahaan, opt => opt.MapFrom(c => c.AlamatP))
                   .ForMember(cDTO => cDTO.KelurahanPerusahaan, opt => opt.MapFrom(c => c.Kel))
                     .ForMember(cDTO => cDTO.KecamatanPerusahaan, opt => opt.MapFrom(c => c.Kec))
                       .ForMember(cDTO => cDTO.KotaPerusahaan, opt => opt.MapFrom(c => c.Kota))
                        .ForMember(cDTO => cDTO.PropinsiPerusahaan, opt => opt.MapFrom(c => c.Propinsi))
                         .ForMember(cDTO => cDTO.KodePos, opt => opt.MapFrom(c => c.KodePos))
                          .ForMember(cDTO => cDTO.Telp, opt => opt.MapFrom(c => c.Telp))
                            .ForMember(cDTO => cDTO.Cs, opt => opt.MapFrom(c => c.Cs));

            //   .ForMember(cDTO => cDTO.NamaPerusahaan, opt => opt.MapFrom(c => string.Format("{0} - {1} - {2:c}", c.NamaBarang, c.Merek, (c.Harga + c.BBN))));


        }
    }
}
