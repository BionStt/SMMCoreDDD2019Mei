using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain
{
    public class DataSPKKredit
    {
        public Guid DataSPKKreditId { get; set; }
        public decimal? BiayaAdministrasiKredit { get; private set; }
        public decimal? BiayaAdministrasiTunai { get; private set; }
        public decimal? BBN { get; private set; }
        public decimal? DendaWilayah { get; private set; }
        public decimal? DiskonDP { get; private set; }
        public decimal? DiskonTunai { get; private set; }
        public decimal? DPPriceList { get; private set; }
        public decimal? Komisi { get; private set; }
        public decimal? OffTheRoad { get; private set; }
        public decimal? Promosi { get; private set; }
        public decimal? UangTandaJadiTunai { get; private set; }
        public decimal? UangTandaJadiKredit { get; private set; }
        public string UserName { get; set; }
        public Guid UserNameId { get; set; }

        public int NoUrutId { get; set; }
        //relationship
        public Guid DataSPKId { get; private set; }

        public static DataSPKKredit CreateDataSPKKredit(decimal? biayaAdministrasiKredit, decimal? biayaAdministrasiTunai, decimal? bBN, decimal? dendaWilayah, decimal? diskonDP, decimal? diskonTunai, decimal? dPPriceList, decimal? komisi, decimal? offTheRoad, decimal? promosi, decimal? uangTandaJadiTunai, decimal? uangTandaJadiKredit, Guid dataSPKId, string userName, Guid userNameId)
        {
            return new DataSPKKredit(biayaAdministrasiKredit,biayaAdministrasiTunai,bBN,dendaWilayah,diskonDP,diskonTunai,dPPriceList,komisi,offTheRoad,promosi,uangTandaJadiTunai,uangTandaJadiKredit,dataSPKId,userName,userNameId);
        }
        private DataSPKKredit(decimal? biayaAdministrasiKredit, decimal? biayaAdministrasiTunai, decimal? bBN, decimal? dendaWilayah, decimal? diskonDP, decimal? diskonTunai, decimal? dPPriceList, decimal? komisi, decimal? offTheRoad, decimal? promosi, decimal? uangTandaJadiTunai, decimal? uangTandaJadiKredit, Guid dataSPKId, string userName, Guid userNameId)
        {
            DataSPKKreditId = Guid.NewGuid();
            BiayaAdministrasiKredit = biayaAdministrasiKredit;
            BiayaAdministrasiTunai = biayaAdministrasiTunai;
            BBN = bBN;
            DendaWilayah = dendaWilayah;
            DiskonDP = diskonDP;
            DiskonTunai = diskonTunai;
            DPPriceList = dPPriceList;
            Komisi = komisi;
            OffTheRoad = offTheRoad;
            Promosi = promosi;
            UangTandaJadiTunai = uangTandaJadiTunai;
            UangTandaJadiKredit = uangTandaJadiKredit;
            DataSPKId = dataSPKId;
            UserName=userName;
            UserNameId=userNameId;
        }
        public void EditDataSPKKredit(decimal? biayaAdministrasiKredit, decimal? biayaAdministrasiTunai, decimal? bBN, decimal? dendaWilayah, decimal? diskonDP, decimal? diskonTunai, decimal? dPPriceList, decimal? komisi, decimal? offTheRoad, decimal? promosi, decimal? uangTandaJadiTunai, decimal? uangTandaJadiKredit)
        {
            BiayaAdministrasiKredit = biayaAdministrasiKredit;
            BiayaAdministrasiTunai = biayaAdministrasiTunai;
            BBN = bBN;
            DendaWilayah = dendaWilayah;
            DiskonDP = diskonDP;
            DiskonTunai = diskonTunai;
            DPPriceList = dPPriceList;
            Komisi = komisi;
            OffTheRoad = offTheRoad;
            Promosi = promosi;
            UangTandaJadiTunai = uangTandaJadiTunai;
            UangTandaJadiKredit = uangTandaJadiKredit;
        }
        protected DataSPKKredit()
        {

        }



    }
}
