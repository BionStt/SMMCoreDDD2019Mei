﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.Pembelians.Query.GetNamaPO
{
    public class GetNamaPOLookUpModel : IHaveCustomMapping
    {
        public int NoUrutPoPembelian { get; set; }
        public string NamaPOPembelian { get; set; }
      
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<PembelianPO, GetNamaPOLookUpModel>()
             .ForMember(cDTO => cDTO.NoUrutPoPembelian, opt => opt.MapFrom(c => c.Id))
            // .ForMember(cDTO => cDTO.NamaBarang, opt => opt.MapFrom(c => c.NamaBarang));
            .ForMember(cDTO => cDTO.NamaPOPembelian, opt => opt.MapFrom(c => string.Format("{0} - {1:d} - {2}", c.Id, c.TglPo, c.MasterSupplierDBId)));


        }
    }
}
