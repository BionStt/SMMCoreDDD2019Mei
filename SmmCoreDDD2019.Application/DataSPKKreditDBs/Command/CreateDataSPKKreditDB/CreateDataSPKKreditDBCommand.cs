using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Application.DataSPKKreditDBs.Command.CreateDataSPKKreditDB
{
    public class CreateDataSPKKreditDBCommand:IRequest
    {
        //  public int NoUrut { get; set; }
        [Display(Name = "Nama Pemesan")]
        public int? NoUrutSPKBaru { get; set; }
        [Display(Name = "Off The Road")]
        public decimal? OffTheRoad { get; set; }
        [Display(Name = "BBN")]
        public decimal? BBN { get; set; }
        [Display(Name = "DP Price List")]
        public decimal? DPPriceList { get; set; }
        [Display(Name = "Diskon DP")]
        public decimal? DiskonDP { get; set; }
        [Display(Name = "Tanda Jadi Tunai")]
        public decimal? UangTandaJadiTunai { get; set; }
        [Display(Name = "Tanda Jadi Kredit")]
        public decimal? UangTandaJadiKredit { get; set; }
        [Display(Name = "Diskon Tunai")]
        public decimal? DiskonTunai { get; set; }
        [Display(Name = "Promosi")]
        public decimal? Promosi { get; set; }
        [Display(Name = "Denda Wilayah")]
        public decimal? DendaWilayah { get; set; }
        [Display(Name = "ADM Tunai")]
        public decimal? BiayaAdministrasiTunai { get; set; }
        [Display(Name = "ADM Kredit")]
        public decimal? BiayaAdministrasiKredit { get; set; }
      
         [Display(Name = "Komisi")]
        public decimal? Komisi { get; set; }
     
       
       // public DataSPKBaruDB DataSPKBaruDB { get; set; }
        // public DataSpkbaruDb NourutSpkbaruNavigation { get; set; }
    }
}
