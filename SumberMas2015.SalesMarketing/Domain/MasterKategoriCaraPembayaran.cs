
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain
{
    public class MasterKategoriCaraPembayaran
    {
        public Guid MasterKategoriCaraPembayaranId { get; set; }
        public string CaraPembayaran { get; private set; }
        public int NoUrutId { get; set; }
        protected MasterKategoriCaraPembayaran()
        {

        }
        private MasterKategoriCaraPembayaran(string caraPembayaran)
        {
            MasterKategoriCaraPembayaranId = Guid.NewGuid();
            CaraPembayaran = caraPembayaran;
        }
        public static MasterKategoriCaraPembayaran Create(string caraPembayaran)
        {
            return new MasterKategoriCaraPembayaran(caraPembayaran);
        }
        public void EditMasterKategoriCaraPembayaran(string caraPembayaran)
        {
            CaraPembayaran = caraPembayaran;
        }
    }
}
