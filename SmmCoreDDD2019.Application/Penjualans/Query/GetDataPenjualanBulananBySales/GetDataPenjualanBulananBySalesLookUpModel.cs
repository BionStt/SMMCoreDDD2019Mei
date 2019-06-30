using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.Penjualans.Query.GetDataPenjualanBulananBySales
{
    public class GetDataPenjualanBulananBySalesLookUpModel : IHaveCustomMapping
    {
        public int KodePenjualanID { get; set; }
        public DateTime TanggalPenjualan { get; set; }
        public string NoBuku { get; set; }
        public string NamaKonsumen { get; set; }
        public string NamaBPKB { get; set; }
        public string AlamatKonsumen { get; set; }
        public string Kelurahan { get; set; }
        public string Kecamatan { get; set; }
        public string Kota { get; set; }
        public string Propinsi { get; set; }
        public string Handphone { get; set; }
        public string Telepon { get; set; }

        public string Merek { get; set; }
        public string NamaBarang { get; set; }
        public string NamaLeasing { get; set; }
        public string CabangLeasing { get; set; }
        public string NamaSales { get; set; }
        public string Supplier { get; set; }
        public string KategoryPenjualan { get; set; }
        public string NoRangka { get; set; }
        public string NoMesin { get; set; }
        public decimal OTR { get; set; }
        public decimal DiscTunai { get; set; }

        public decimal OTRByr { get; set; }
        public decimal DP { get; set; }
        public decimal DiscDP { get; set; }
        public decimal DPByr { get; set; }
        public decimal SPFF { get; set; }

        public decimal SellOutt { get; set; }
        public decimal DenWil { get; set; }
        public decimal SubK { get; set; }
        public decimal Komisii { get; set; }
        public decimal JPII { get; set; }
        public decimal Promosi1 { get; set; }
        public decimal JPI { get; set; }
        public DateTime tglLunasLeasing { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Penjualan, GetDataPenjualanBulananBySalesLookUpModel>()
             .ForMember(cDTO => cDTO.KodePenjualanID, opt => opt.MapFrom(c => c.Id));
            //  .ForMember(cDTO => cDTO.NamaPemesan, opt => opt.MapFrom(c => c.NamaPemesan));

        }
    }
}
