using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataCheckPenjualanDetailBulanan
{
    public class GetDataCheckPenjualanDetailBulananLookUpModel : IHaveCustomMapping
    {
        public int NoUrutPenjualanDetail { get; set; }
        public string KodeKonsumen { get; set; }
        public string NamaKonsumen { get; set; }
        public string NamaBPKB { get; set; }
        public string NamaFaktur { get; set; }
        public string NoUrutPenjualan { get; set; }
        public DateTime TanggalPenjualan { get; set; }
        public string Merek { get; set; }
        public string NamaBarang { get; set; }
        public string Warna { get; set; }
        public string NoRangka { get; set; }
        public string NoMesin { get; set; }
        public string SalesForce { get; set; }
        public string KategoriPenjualan { get; set; }
        public string Mediator1 { get; set; }
        public string NamaSupplier { get; set; }
        public decimal DiskonUnit { get; set; }
        public decimal SellIn { get; set; }
        public string NoUrutSO { get; set; }
        public string TanggalBeliUnit { get; set; }
        public decimal HargaOTR { get; set; }
        public decimal UangMuka { get; set; }
        public decimal DiskonKredit { get; set; }
        public decimal DPBayar { get; set; }
        public decimal DiskonTunai { get; set; }
        public decimal Subsidi1 { get; set; }
        public decimal Promosi1 { get; set; }
        public decimal Komisi1 { get; set; }
        public decimal JoinPromo2 { get; set; }
        public decimal JoinPromo1 { get; set; }
        public decimal SPF1 { get; set; }
        public decimal SellOut1 { get; set; }
        public decimal DendaWilayah1 { get; set; }
        public decimal Tagihan1 { get; set; }
        public decimal TotalTagihan1 { get; set; }
        public string NamaLeasing { get; set; }
        public string CabangLeasing { get; set; }
        public string NomorPO { get; set; }
        public string NoBuku1 { get; set; }
        public decimal ProfitUnit { get; set; }
        public string NoFaktur { get; set; }
        public DateTime TglLunasLeasing1 { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<PenjualanDetail, GetDataCheckPenjualanDetailBulananLookUpModel>()
             .ForMember(cDTO => cDTO.NoUrutPenjualanDetail, opt => opt.MapFrom(c => c.Id));
            // .ForMember(cDTO => cDTO.NamaBarang, opt => opt.MapFrom(c => c.NamaBarang));
            //  .ForMember(cDTO => cDTO.NamaPembelian, opt => opt.MapFrom(c => string.Format("{0} - {1:d} - {2}", c.KodeBeli, c.TglBeli, c.Idsupplier)));


        }
    }
}
