using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.MasterSupplierDBs.Queries.GetNamaSupplier
{
    public class GetNamaSupplierLookUpModel : IHaveCustomMapping
    {
        public int NoUrutSupplier { get; set; }
        public string NamaSupplier { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<MasterSupplierDB, GetNamaSupplierLookUpModel>()
             .ForMember(cDTO => cDTO.NoUrutSupplier, opt => opt.MapFrom(c => c.Id))
             .ForMember(cDTO => cDTO.NamaSupplier, opt => opt.MapFrom(c => c.NamaSupplier));
         //  .ForMember(cDTO => cDTO.NamaSupplier, opt => opt.MapFrom(c => string.Format("{0} - {1} - {2:c}", c.NamaBarang, c.Merek, (c.Harga + c.BBN))));


        }
    }
}
