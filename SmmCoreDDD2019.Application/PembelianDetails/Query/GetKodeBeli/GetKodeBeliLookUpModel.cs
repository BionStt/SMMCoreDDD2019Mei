using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.PembelianDetails.Query.GetKodeBeli
{
    public class GetKodeBeliLookUpModel : IHaveCustomMapping
    {
        public int NoUrutPembelian { get; set; }
        public string NamaPembelian { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Pembelian, GetKodeBeliLookUpModel>()
             .ForMember(cDTO => cDTO.NoUrutPembelian, opt => opt.MapFrom(c => c.Id))
            // .ForMember(cDTO => cDTO.NamaBarang, opt => opt.MapFrom(c => c.NamaBarang));
            .ForMember(cDTO => cDTO.NamaPembelian, opt => opt.MapFrom(c => string.Format("{0} - {1:d} - {2}", c.Id, c.TglBeli, c.MasterSupplierDBId)));


        }
    }
}
