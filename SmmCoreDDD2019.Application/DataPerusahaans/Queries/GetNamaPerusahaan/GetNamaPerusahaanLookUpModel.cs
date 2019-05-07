using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.DataPerusahaans.Queries.GetNamaPerusahaan
{
    public class GetNamaPerusahaanLookUpModel : IHaveCustomMapping
    {
        public int IDPerusahaan { get; set; }
        public string NamaPerusahaan { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<DataPerusahaan, GetNamaPerusahaanLookUpModel>()
             .ForMember(cDTO => cDTO.IDPerusahaan, opt => opt.MapFrom(c => c.KodeP))
            .ForMember(cDTO => cDTO.NamaPerusahaan, opt => opt.MapFrom(c => c.NamaP));
         //   .ForMember(cDTO => cDTO.NamaPerusahaan, opt => opt.MapFrom(c => string.Format("{0} - {1} - {2:c}", c.NamaBarang, c.Merek, (c.Harga + c.BBN))));


        }
    }
}
