using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.PembelianDetails.Query.GetListPembelianDetail
{
    public class GetListPembelianDetailLookUpModel : IHaveCustomMapping
    {
        public int NoUrutPembelianDetail { get; set; }
        public string NamaBarang1 { get; set; }
        public string HargaOff { get; set; }
        public string BBN1 { get; set; }
        public string HargaOTr { get; set; }
        public string Diskon { get; set; }
        public string SellIn { get; set; }
        public int Qty1 { get; set; }
        public string Count1 { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<PembelianDetail, GetListPembelianDetailLookUpModel>()
             .ForMember(cDTO => cDTO.NoUrutPembelianDetail, opt => opt.MapFrom(c => c.Id));
            // .ForMember(cDTO => cDTO.NamaBarang, opt => opt.MapFrom(c => c.NamaBarang));
          // .ForMember(cDTO => cDTO.NamaPembelian, opt => opt.MapFrom(c => string.Format("{0} - {1:d} - {2}", c.KodeBeli, c.TglBeli, c.Idsupplier)));


        }
    }
}
