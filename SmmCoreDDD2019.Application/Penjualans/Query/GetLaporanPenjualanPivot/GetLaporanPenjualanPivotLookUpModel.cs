﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.Penjualans.Query.GetLaporanPenjualanPivot
{
    public class GetLaporanPenjualanPivotLookUpModel : IHaveCustomMapping
    {
        public string NamaLeasing { get; set; }
        public int HONDA { get; set; }
        public int YAMAHA { get; set; }
        public int SUZUKI { get; set; }
        public int KAWASAKI { get; set; }
        public int TtlRow { get; set; }
        public int KodePenjualanID { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Penjualan, GetLaporanPenjualanPivotLookUpModel>()
             .ForMember(cDTO => cDTO.KodePenjualanID, opt => opt.MapFrom(c => c.KodePenjualan));
            //  .ForMember(cDTO => cDTO.NamaPemesan, opt => opt.MapFrom(c => c.NamaPemesan));

        }
    }
}