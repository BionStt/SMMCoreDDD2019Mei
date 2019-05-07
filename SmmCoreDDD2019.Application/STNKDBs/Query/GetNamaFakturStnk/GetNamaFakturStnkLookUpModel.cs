
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmmCoreDDD2019.Domain.Entities;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
namespace SmmCoreDDD2019.Application.STNKDBs.Query.GetNamaFakturStnk
{
    public class GetNamaFakturStnkLookUpModel : IHaveCustomMapping
    {
        public int NoUrutFaktur1 { get; set; }
        public string NamaFaktur { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<PermohonanFakturDB, GetNamaFakturStnkLookUpModel>()
             .ForMember(cDTO => cDTO.NoUrutFaktur1, opt => opt.MapFrom(c => c.NoUrutFaktur));
            // .ForMember(cDTO => cDTO.NamaBarang, opt => opt.MapFrom(c => c.NamaBarang));
           // .ForMember(cDTO => cDTO.NamaFaktur, opt => opt.MapFrom(c => string.Format("{0} - {1:d} - {2}", c.NoUrutPo, c.TglPo, c.NoDealer)));


        }
    }
}
