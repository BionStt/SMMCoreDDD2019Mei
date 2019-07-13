﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.DataPerusahaanOrgChartDB.Query.GetOrgChartByDepthByChart
{
    public class GetOrgChartByDepthByChartLookUpModel : IHaveCustomMapping
    {
        public int NoUrutStrukturID { get; set; }
        public string KodeStrukturJabatan { get; set; }
        public string NamaStrukturJabatan { get; set; }

        public int Depth { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<DataPerusahaanOrgChart, GetOrgChartByDepthByChartLookUpModel>()
                .ForMember(cDTO => cDTO.NoUrutStrukturID, opt => opt.MapFrom(c => c.Id))
                .ForMember(cDTO => cDTO.KodeStrukturJabatan, opt => opt.MapFrom(c => c.KodeStrukturJabatan))
                  .ForMember(cDTO => cDTO.NamaStrukturJabatan, opt => opt.MapFrom(c => c.NamaStrukturJabatan))
                                        .ForMember(cDTO => cDTO.Depth, opt => opt.MapFrom(c => c.Depth));
        }
    }
}
