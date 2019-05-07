using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataCekDPPenjualan2
{
    public class GetDataCekDPPenjualan2LookUpModel : IHaveCustomMapping
    {
        public int NoUrutPenjualanDetail { get; set; }
        public string DataPenjualan { get; set; }

        public DateTime TanggalPenjualan { get; set; }
        public string CheckDP { get; set; }
        public string KodePenjualan { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<PenjualanDetail, GetDataCekDPPenjualan2LookUpModel>()
             .ForMember(cDTO => cDTO.NoUrutPenjualanDetail, opt => opt.MapFrom(c => c.NoPenjualanDetail));
            // .ForMember(cDTO => cDTO.NamaBarang, opt => opt.MapFrom(c => c.NamaBarang));
            //  .ForMember(cDTO => cDTO.NamaPembelian, opt => opt.MapFrom(c => string.Format("{0} - {1:d} - {2}", c.KodeBeli, c.TglBeli, c.Idsupplier)));


        }
    }
}
