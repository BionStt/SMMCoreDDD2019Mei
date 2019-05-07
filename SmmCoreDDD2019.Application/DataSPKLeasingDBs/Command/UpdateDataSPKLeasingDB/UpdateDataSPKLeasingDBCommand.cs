using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.DataSPKLeasingDBs.Command.UpdateDataSPKLeasingDB
{
    public class UpdateDataSPKLeasingDBCommand:IRequest
    {
        public int NoUrut { get; set; }
        public decimal? Angsuran { get; set; }
        public int? NoUrutLeasingCabang { get; set; }
        public string Mediator { get; set; }
        public string NamaCmo { get; set; }
        public int? NoUrutKategoriBayaran { get; set; }
        public int? NoUrutKategoriPenjualan { get; set; }
        //  public int? NoUrutMarco { get; set; }
        public int? NoUrutSales { get; set; }
        public int? NoUrutSPKBaru { get; set; }
        public int? Tenor { get; set; }
        public DateTime? TglSurvei { get; set; }

        //public NamaLease IdleaseNavigation { get; set; }
        //public MasterKategoryBayaran NoUrutKatByrNavigation { get; set; }
        //public MasterKategoryPenjualan NoUrutKategoriPjNavigation { get; set; }
        //public MarcoDb NoUrutMarcoNavigation { get; set; }
        //public SalesForceDb NoUrutSalesNavigation { get; set; }
     //   public DataSPKBaruDB DataSPKBaruDB { get; set; }
    //    public MasterKategoriBayaran MasterKategoriBayaran { get; set; }
    //    public MasterKategoriPenjualan MasterKategoriPenjualan { get; set; }
    //    public MasterLeasingCabangDB MasterLeasingCabangDB { get; set; }
        // public MasterLeasingDb MasterLeasingDb { get; set; }
    }
}
