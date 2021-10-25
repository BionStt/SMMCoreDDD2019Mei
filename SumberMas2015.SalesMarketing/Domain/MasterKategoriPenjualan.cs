using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain
{
    public class MasterKategoriPenjualan
    {
        protected MasterKategoriPenjualan()
        {

        }
        private MasterKategoriPenjualan(string namaKategoryPenjualan)
        {
            MasterKategoriPenjualanId = Guid.NewGuid();
            NamaKategoryPenjualan = namaKategoryPenjualan;
        }
        public static MasterKategoriPenjualan Create(string namaKategoryPenjualan)
        {
            return new MasterKategoriPenjualan(namaKategoryPenjualan);
        }
        public string NamaKategoryPenjualan { get; private set; }
        public Guid MasterKategoriPenjualanId { get; private set; }
        public int NoUrutId { get; private set; }
        public void EditMasterKategoriPenjualan(string namaKategoryPenjualan)
        {
            NamaKategoryPenjualan = namaKategoryPenjualan;
        }
    }
}

