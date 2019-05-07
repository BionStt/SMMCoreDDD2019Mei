using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataPiutangLeasing
{
    public class GetDataPiutangLeasingLookUpModel : IHaveCustomMapping
    {
        public int NoUrutPenjualanDetail { get; set; }
        public string NamaKonsumen { get; set; }
        public string NamaBPKB { get; set; }
        public string AlamatKonsumen { get; set; }
        public string KelurahanK { get; set; }
        public string KecamatanK { get; set; }
        public string KotaK { get; set; }
        public string PropinsiK { get; set; }
        public string KodePosK { get; set; }
        public string NoTelepon { get; set; }
        public string NoHandphone { get; set; }
        public string Keterangan { get; set; }
        public string NoBuku { get; set; }
        public string Merek { get; set; }
        public string NamaBarang { get; set; }
        public string TypeKendaraan1 { get; set; }
        public string Noka1 { get; set; }
        public string Nosin1 { get; set; }
        public string NoRangka { get; set; }
        public string NoMesin { get; set; }
        public string Warna { get; set; }
        public decimal UangMuka { get; set; }
        public decimal DiskonKredit1 { get; set; }
        public decimal DiskonTunai1 { get; set; }
        public decimal DendaWilayah { get; set; }
        public decimal HargaOtr1 { get; set; }
        public decimal JoinPromo1 { get; set; }
        public decimal JoinPromo2 { get; set; }
        public decimal Komisi { get; set; }
        public decimal OffTheRoad { get; set; }
        public decimal BBN { get; set; }
        public decimal Promosi { get; set; }
        public decimal SellOut { get; set; }
        public decimal SPF { get; set; }
        public decimal Subdisi { get; set; }
        public string Mediator1 { get; set; }
        public string NamaSales { get; set; }
        public string HandphoneSales { get; set; }
        public string KategoriPenjualan { get; set; }
        public string NamaLeasing { get; set; }
        public string CabangLeasing { get; set; }
        public decimal DpBayar { get; set; }
        public decimal HargaTagihan { get; set; }
        public DateTime TanggalPenjualan { get; set; }
        public string NamaSupplier { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<PenjualanDetail, GetDataPiutangLeasingLookUpModel>()
             .ForMember(cDTO => cDTO.NoUrutPenjualanDetail, opt => opt.MapFrom(c => c.NoPenjualanDetail));
            // .ForMember(cDTO => cDTO.NamaBarang, opt => opt.MapFrom(c => c.NamaBarang));
            //  .ForMember(cDTO => cDTO.NamaPembelian, opt => opt.MapFrom(c => string.Format("{0} - {1:d} - {2}", c.KodeBeli, c.TglBeli, c.Idsupplier)));


        }
    }
}
