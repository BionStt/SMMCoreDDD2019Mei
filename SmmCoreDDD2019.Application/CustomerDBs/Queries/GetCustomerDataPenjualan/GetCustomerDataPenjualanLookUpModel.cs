using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerDataPenjualan
{
    public class GetCustomerDataPenjualanLookUpModel : IHaveCustomMapping
    {
        public int NoCustomer { get; set; }
        public string NamaKonsumen {get;set;}

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<CustomerDB, GetCustomerDataPenjualanLookUpModel>()
             .ForMember(cDTO => cDTO.NoCustomer, opt => opt.MapFrom(c => c.Id))
             .ForMember(cDTO => cDTO.NamaKonsumen, opt => opt.MapFrom(c => c.Nama));
            //  .ForMember(cDTO => cDTO.NamaPembelian, opt => opt.MapFrom(c => string.Format("{0} - {1:d} - {2}", c.KodeBeli, c.TglBeli, c.Idsupplier)));


        }
    }
}
