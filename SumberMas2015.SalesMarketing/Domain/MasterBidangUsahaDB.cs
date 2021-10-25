using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
            NamaMasterBidangUsahaGuid = Guid.NewGuid();
        }
        // [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NoUrutId { get; set; }
        public Guid NamaMasterBidangUsahaGuid { get; set; }
        public string NamaMasterBidangUsaha { get;private set; }
        public DateTime TanggalInput { get; set; }
    }
}
