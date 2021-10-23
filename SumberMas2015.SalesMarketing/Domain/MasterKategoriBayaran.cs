
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain
{
    public class MasterKategoriBayaran
    {
        public Guid MasterKategoriBayaranId { get; set; }
        public string NamaKategoryBayaran { get; set; }
        public int NoUrutId { get; set; }
        protected MasterKategoriBayaran()
        {

        }
        private MasterKategoriBayaran(string namaKategoryBayaran)
        {
            MasterKategoriBayaranId = Guid.NewGuid();
            NamaKategoryBayaran = namaKategoryBayaran;
        }
        public static MasterKategoriBayaran Create(string namaKategoryBayaran)
        {
            return new MasterKategoriBayaran(namaKategoryBayaran);
        }
        public void EditMasterKategoriBayaran(string namaKategoryBayaran)
        {
            NamaKategoryBayaran = namaKategoryBayaran;
        }
    }
}
