using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.Domain
{
    public class DataPerusahaanVisi
    {
        public static DataPerusahaanVisi CreateVisi(string visi)
        {
            return new DataPerusahaanVisi(visi);
        }
        private DataPerusahaanVisi(  string visi  )
        {
            DataPerusahaanVisiId=Guid.NewGuid();
            Visi=visi;
            TanggalInput=DateTime.Now;
        }

        public Guid DataPerusahaanVisiId { get; set; }
        public string Visi { get; set; }
        public DateTime TanggalInput{ get; set; }

        public int NoUrutId { get; set; }



    }
}
