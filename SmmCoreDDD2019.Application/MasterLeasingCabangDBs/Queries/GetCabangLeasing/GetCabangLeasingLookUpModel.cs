using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.MasterLeasingCabangDBs.Queries.GetCabangLeasing
{
    public class GetCabangLeasingLookUpModel : IHaveCustomMapping
    {
        public int NoUrutLeasingCabang { get; set; }
        public string NamaCab { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<MasterLeasingCabangDB, GetCabangLeasingLookUpModel>()
             .ForMember(cDTO => cDTO.NoUrutLeasingCabang, opt => opt.MapFrom(c => c.Id))
             .ForMember(cDTO => cDTO.NamaCab, opt => opt.MapFrom(c => c.Cabang));

        }
    }
}
