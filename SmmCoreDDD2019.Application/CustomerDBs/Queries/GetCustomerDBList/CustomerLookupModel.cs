using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerDBList
{
    public class CustomerLookupModel : IHaveCustomMapping
    {
        public string Id { get; set; }
        public string Name { get; set; }


        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<CustomerDB, CustomerLookupModel>()
                .ForMember(cDTO => cDTO.Id, opt => opt.MapFrom(c => c.Id))
                .ForMember(cDTO => cDTO.Name, opt => opt.MapFrom(c => c.Nama));
        }
    }
}
