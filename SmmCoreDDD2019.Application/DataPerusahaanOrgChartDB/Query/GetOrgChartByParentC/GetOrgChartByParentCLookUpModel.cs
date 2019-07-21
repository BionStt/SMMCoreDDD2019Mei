using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.DataPerusahaanOrgChartDB.Query.GetOrgChartByParentC
{
    public class GetOrgChartByParentCLookUpModel : IHaveCustomMapping
    {
        public int NoUrutStrukturID { get; set; }
        public string DataAkun1 { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<DataPerusahaanOrgChart, GetOrgChartByParentCLookUpModel>()
                .ForMember(cDTO => cDTO.NoUrutStrukturID, opt => opt.MapFrom(c => c.Id))
                 .ForMember(cDTO => cDTO.DataAkun1, opt => opt.MapFrom(c => string.Format("{0}", "[" + c.KodeStrukturJabatan + "] - " + c.NamaStrukturJabatan)));

        }
    }
}
