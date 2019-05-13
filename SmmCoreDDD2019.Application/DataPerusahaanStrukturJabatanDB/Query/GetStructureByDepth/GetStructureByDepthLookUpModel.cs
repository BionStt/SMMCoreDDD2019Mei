using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDB.Query.GetStructureByDepth
{
    public class GetStructureByDepthLookUpModel : IHaveCustomMapping
    {
        public int NoUrutStrukturID { get; set; }
        public string KodeStruktur { get; set; }
        public string NamaStrukturJabatan { get; set; }
        public string DataAkun1 { get; set; }
        public string DataAkun2 { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<DataPerusahaanStrukturJabatan, GetStructureByDepthLookUpModel>()
               .ForMember(cDTO => cDTO.NoUrutStrukturID, opt => opt.MapFrom(c => c.NoUrutStrukturID))
               .ForMember(cDTO => cDTO.KodeStruktur, opt => opt.MapFrom(c => c.KodeStruktur))
                 .ForMember(cDTO => cDTO.NamaStrukturJabatan, opt => opt.MapFrom(c => c.NamaStrukturJabatan));




        }
    }
}
