using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDB.Query.GetStructureByStructureCode
{
    public class GetStructureByStructureCodeLookUpModel : IHaveCustomMapping
    {
        public int NoUrutStruktur { get; set; }
        public string KodeStruktur { get; set; }
        public string NamaStrukturJabatan { get; set; }
    
        public int Depth { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<DataPerusahaanStrukturJabatan, GetStructureByStructureCodeLookUpModel>()
               .ForMember(cDTO => cDTO.NoUrutStruktur, opt => opt.MapFrom(c => c.NoUrutStruktur))
               .ForMember(cDTO => cDTO.KodeStruktur, opt => opt.MapFrom(c => c.KodeStruktur))
                 .ForMember(cDTO => cDTO.NamaStrukturJabatan, opt => opt.MapFrom(c => c.NamaStrukturJabatan))
                                       .ForMember(cDTO => cDTO.Depth, opt => opt.MapFrom(c => c.Depth));
            
         
        }
    }
}
