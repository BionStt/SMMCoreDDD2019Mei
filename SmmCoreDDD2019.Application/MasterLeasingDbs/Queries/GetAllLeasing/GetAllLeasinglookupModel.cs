using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.MasterLeasingDbs.Queries.GetAllLeasing
{
    public class GetAllLeasinglookupModel:IHaveCustomMapping
    {
        public int IDlease { get; set; }
        public string NamaLease { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<MasterLeasingDb, GetAllLeasinglookupModel>()
               .ForMember(cDTO => cDTO.IDlease, opt => opt.MapFrom(c => c.IDlease))
               .ForMember(cDTO => cDTO.NamaLease, opt => opt.MapFrom(c => c.NamaLease));

            // throw new NotImplementedException();
        }
    }
}
