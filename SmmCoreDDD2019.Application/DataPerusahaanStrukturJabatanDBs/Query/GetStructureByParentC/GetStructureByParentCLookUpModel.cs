﻿using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDBs.Query.GetStructureByParentC
{
    public class GetStructureByParentCLookUpModel : IHaveCustomMapping
    {
        public int NoUrutStrukturID { get; set; }
        public string DataAkun1 { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<DataPerusahaanStrukturJabatan, GetStructureByParentCLookUpModel>()
                .ForMember(cDTO => cDTO.NoUrutStrukturID, opt => opt.MapFrom(c => c.NoUrutStrukturID));

            // .ForMember(cDTO => cDTO.DataAkun, opt => opt.Ignore());
            // .ForMember(cDTO => cDTO.KodeAccount, opt => opt.MapFrom(c => c.KodeAccount))
            //   .ForMember(cDTO => cDTO.Account, opt => opt.MapFrom(c => c.Account))
            //     .ForMember(cDTO => cDTO.NormalPos, opt => opt.MapFrom(c => c.NormalPos))
            //           .ForMember(cDTO => cDTO.Depth, opt => opt.MapFrom(c => c.Depth))
            //.ForMember(cDTO => cDTO.Kelompok, opt => opt.MapFrom(c => c.Kelompok));
        }
    }
}