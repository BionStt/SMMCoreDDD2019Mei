using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
   public class DataSPKKreditDB : BaseEntity
    {

       // public int NoUrut { get; set; }
        public decimal? BiayaAdministrasiKredit { get; set; }
        public decimal? BiayaAdministrasiTunai { get; set; }
        public decimal? BBN { get; set; }
        public decimal? DendaWilayah { get; set; }
        public decimal? DiskonDP { get; set; }
        public decimal? DiskonTunai { get; set; }
        public decimal? DPPriceList { get; set; }
        public decimal? Komisi { get; set; }
        public int? NoUrutSPKBaru { get; set; }
        public decimal? OffTheRoad { get; set; }
        public decimal? Promosi { get; set; }
        public decimal? UangTandaJadiTunai { get; set; }
        public decimal? UangTandaJadiKredit { get; set; }
        public DataSPKBaruDB DataSPKBaruDB { get; set; }
        // public DataSpkbaruDb NourutSpkbaruNavigation { get; set; }
    }
}
