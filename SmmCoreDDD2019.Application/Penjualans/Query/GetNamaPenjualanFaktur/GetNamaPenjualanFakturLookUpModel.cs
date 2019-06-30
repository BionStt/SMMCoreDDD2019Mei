using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.Penjualans.Query.GetNamaPenjualanFaktur
{
    public class GetNamaPenjualanFakturLookUpModel : IHaveCustomMapping
    {
        public int NoPenjualanDetail { get; set; }
        public string NamaKonsumen1 { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<PenjualanDetail, GetNamaPenjualanFakturLookUpModel>()
             .ForMember(cDTO => cDTO.NoPenjualanDetail, opt => opt.MapFrom(c => c.Id));
            //  .ForMember(cDTO => cDTO.NamaPemesan, opt => opt.MapFrom(c => c.NamaPemesan));

        }
    }
}
