using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.PembelianDetails.Query.GetKodeBeliDetail
{
    public class GetKodeBeliDetailLookUpModel : IHaveCustomMapping
    {
        public int NoKodeBeli1 { get; set; }
        public int NoKodeBeliDetail { get; set; }
        public int KodeBarang { get; set; }
        public string NamaBarang1 { get; set; }
      public decimal HargaOff { get; set; }
       
        public decimal Diskon1 { get; set; }
        public decimal SellIn1 { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<PembelianDetail, GetKodeBeliDetailLookUpModel>()
             .ForMember(cDTO => cDTO.NoKodeBeliDetail, opt => opt.MapFrom(c => c.KodeBeliDetail));
            // .ForMember(cDTO => cDTO.NamaBarang, opt => opt.MapFrom(c => c.NamaBarang));
          //  .ForMember(cDTO => cDTO.NamaPembelian, opt => opt.MapFrom(c => string.Format("{0} - {1:d} - {2}", c.KodeBeli, c.TglBeli, c.Idsupplier)));


        }
    }
}
