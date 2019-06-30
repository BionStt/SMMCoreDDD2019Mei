using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.DataKonsumenAvalistDbs.Query.GetDataKonsumenAvalist
{
    public class GetDataKonsumenAvalistLookUpModel : IHaveCustomMapping
    {
        public int NoCustomerAvalist { get; set; }
        public string NamaKonsumen { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<DataKonsumenAvalist, GetDataKonsumenAvalistLookUpModel>()
             .ForMember(cDTO => cDTO.NoCustomerAvalist, opt => opt.MapFrom(c => c.Id));
             //.ForMember(cDTO => cDTO.NamaKonsumen, opt => opt.MapFrom(c => c.nama));
            //  .ForMember(cDTO => cDTO.NamaPembelian, opt => opt.MapFrom(c => string.Format("{0} - {1:d} - {2}", c.KodeBeli, c.TglBeli, c.Idsupplier)));


        }
    }
}
