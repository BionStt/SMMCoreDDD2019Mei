using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain
{
    public class DataPenjualanDetail
    {
        public Guid DataPenjualanDetailId { get; set; }
        public Guid? DataPenjualanId { get; set; }
        public Guid? StokUnitId { get; set; }
        public decimal? OffTheRoad { get; set; }
        public decimal? BBN { get; set; }
        public decimal? HargaOTR { get; set; }
        public decimal? UangMuka { get; set; }
        public decimal? DiskonKredit { get; set; }
        public decimal? DiskonTunai { get; set; }
        public decimal? Subsidi { get; set; }
        public decimal? Promosi { get; set; }
        public decimal? Komisi { get; set; }
        public decimal? JoinPromo1 { get; set; }
        public decimal? JoinPromo2 { get; set; }
        public decimal? SPF { get; set; }
        public decimal? SellOut { get; set; }
        public decimal? DendaWilayah { get; set; }
        public string CheckDp { get; set; }
        public string CheckLapBulanan { get; set; }
        public DateTime? TanggalCheckLapBulanan { get; set; }
        public string UserCheckLapBulanan { get; set; }
        public int NoUrutId { get; set; }
        public Guid UserNameId { get; set; }
        public string UserName { get; set; }

        public static DataPenjualanDetail CreateDataPenjualanDetail(Guid? dataPenjualanId, Guid? stokUnitId, decimal? offTheRoad, decimal? bBN, decimal? hargaOTR, decimal? uangMuka, decimal? diskonKredit, decimal? diskonTunai, decimal? subsidi, decimal? promosi, decimal? komisi, decimal? joinPromo1, decimal? joinPromo2, decimal? sPF, decimal? sellOut, decimal? dendaWilayah, Guid userNameId, string userName)//, string checkDp, string checkLapBulanan, DateTime? tanggalCheckLapBulanan, string userCheckLapBulanan)
        {
            return new DataPenjualanDetail(dataPenjualanId,stokUnitId,offTheRoad,bBN,hargaOTR,uangMuka,diskonKredit,diskonTunai,subsidi,promosi,komisi,joinPromo1,joinPromo2,sPF,sellOut,dendaWilayah,userNameId,userName);
        }

        private DataPenjualanDetail(Guid? dataPenjualanId, Guid? stokUnitId, decimal? offTheRoad, decimal? bBN, decimal? hargaOTR, decimal? uangMuka, decimal? diskonKredit, decimal? diskonTunai, decimal? subsidi, decimal? promosi, decimal? komisi, decimal? joinPromo1, decimal? joinPromo2, decimal? sPF, decimal? sellOut, decimal? dendaWilayah, Guid userNameId , string userName )//, string checkDp, string checkLapBulanan, DateTime? tanggalCheckLapBulanan, string userCheckLapBulanan)
        {
            DataPenjualanDetailId = Guid.NewGuid();
            DataPenjualanId = dataPenjualanId;
            StokUnitId = stokUnitId;
            OffTheRoad = offTheRoad;
            BBN = bBN;
            HargaOTR = hargaOTR;
            UangMuka = uangMuka;
            DiskonKredit = diskonKredit;
            DiskonTunai = diskonTunai;
            Subsidi = subsidi;
            Promosi = promosi;
            Komisi = komisi;
            JoinPromo1 = joinPromo1;
            JoinPromo2 = joinPromo2;
            SPF = sPF;
            SellOut = sellOut;
            DendaWilayah = dendaWilayah;
            UserNameId=userNameId;
            UserName=userName;
            //  CheckDp = checkDp;
            // CheckLapBulanan = checkLapBulanan;
            //   TanggalCheckLapBulanan = tanggalCheckLapBulanan;
            //  UserCheckLapBulanan = userCheckLapBulanan;
        }


        public void EditDataPenjualanDetail(Guid? dataPenjualanId, Guid? stokUnitId, decimal? offTheRoad, decimal? bBN, decimal? hargaOTR, decimal? uangMuka, decimal? diskonKredit, decimal? diskonTunai, decimal? subsidi, decimal? promosi, decimal? komisi, decimal? joinPromo1, decimal? joinPromo2, decimal? sPF, decimal? sellOut, decimal? dendaWilayah)//, string checkDp, string checkLapBulanan, DateTime? tanggalCheckLapBulanan, string userCheckLapBulanan)
        {
            DataPenjualanId = dataPenjualanId;
            StokUnitId = stokUnitId;
            OffTheRoad = offTheRoad;
            BBN = bBN;
            HargaOTR = hargaOTR;
            UangMuka = uangMuka;
            DiskonKredit = diskonKredit;
            DiskonTunai = diskonTunai;
            Subsidi = subsidi;
            Promosi = promosi;
            Komisi = komisi;
            JoinPromo1 = joinPromo1;
            JoinPromo2 = joinPromo2;
            SPF = sPF;
            SellOut = sellOut;
            DendaWilayah = dendaWilayah;
            //  CheckDp = checkDp;
            // CheckLapBulanan = checkLapBulanan;
            //   TanggalCheckLapBulanan = tanggalCheckLapBulanan;
            //  UserCheckLapBulanan = userCheckLapBulanan;
        }
        protected DataPenjualanDetail()
        {

        }
    }
}
