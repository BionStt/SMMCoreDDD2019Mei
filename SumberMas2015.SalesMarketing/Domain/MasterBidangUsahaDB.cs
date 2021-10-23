using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain
{
    public class MasterBidangUsahaDB
    {
        public static MasterBidangUsahaDB CreateMasterBidangUsahaDB(string namaMasterBidangUsaha)
        {
            return new MasterBidangUsahaDB(namaMasterBidangUsaha);
        }
        private MasterBidangUsahaDB(string namaMasterBidangUsaha)
        {
            NamaMasterBidangUsaha = namaMasterBidangUsaha;
        }
       // [Key]
        public int MasterBidangUsahaDBId { get; set; }
        public string NamaMasterBidangUsaha { get;private set; }
        public DateTime TanggalInput { get; set; }
    }
}
