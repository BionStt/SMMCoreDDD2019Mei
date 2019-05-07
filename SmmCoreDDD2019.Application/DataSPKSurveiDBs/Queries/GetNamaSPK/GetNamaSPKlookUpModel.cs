using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.DataSPKSurveiDBs.Queries.GetNamaSPK
{
    public class GetNamaSPKlookUpModel : IHaveCustomMapping
    {
        public int NoUrutSPKBaru1 { get; set; }
        public string NamaPemesan { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<DataSPKSurveiDB, GetNamaSPKlookUpModel>()
             .ForMember(cDTO => cDTO.NoUrutSPKBaru1, opt => opt.MapFrom(c => c.NoUrutSPKBaru))
            .ForMember(cDTO => cDTO.NamaPemesan, opt => opt.MapFrom(c => c.NamaPemesan));

        }
    }
}
