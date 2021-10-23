using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain
{
    public class MasterBidangPekerjaanDB
    {
        public static MasterBidangPekerjaanDB CreateMasterBidangPekerjaanDB(string namaMasterBidangPekerjaan)
        {
            return new MasterBidangPekerjaanDB(namaMasterBidangPekerjaan);
        }
        private MasterBidangPekerjaanDB(string namaMasterBidangPekerjaan)
        {
            NamaMasterBidangPekerjaan = namaMasterBidangPekerjaan;
        }
        //[Key]
        public int MasterBidangPekerjaanDBId { get; private set; }

        public string NamaMasterBidangPekerjaan { get; private set; }
        public DateTime TanggalInput { get; private set; }
    }
}
