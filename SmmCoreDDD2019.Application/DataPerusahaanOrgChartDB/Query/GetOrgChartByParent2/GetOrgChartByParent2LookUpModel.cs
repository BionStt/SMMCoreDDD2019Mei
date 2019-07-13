using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.DataPerusahaanOrgChartDB.Query.GetOrgChartByParent2
{
    public class GetOrgChartByParent2LookUpModel : IHaveCustomMapping
    {
        public int NoUrutStrukturID { get; set; }
        public string DataAkun { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<DataPerusahaanOrgChart, GetOrgChartByParent2LookUpModel>()
              .ForMember(cDTO => cDTO.NoUrutStrukturID, opt => opt.MapFrom(c => c.Id));
        }
    }
}
