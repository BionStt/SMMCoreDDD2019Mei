using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.MasterKategoriPenjualanDbs.Query.GetNamaKategory
{
    public class GetNamaKategoryLookUpModel : IHaveCustomMapping
    {
        public int NoUrut { get; set; }
        public string NamaKategoryPenjualan { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<MasterKategoriPenjualan, GetNamaKategoryLookUpModel>()
             .ForMember(cDTO => cDTO.NoUrut, opt => opt.MapFrom(c => c.Id))
             .ForMember(cDTO => cDTO.NamaKategoryPenjualan, opt => opt.MapFrom(c => c.NamaKategoryPenjualan));

        }
    }
}
