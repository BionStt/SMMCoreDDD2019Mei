using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.Domain
{
    public class DataPerusahaanMisi
    {
        public static DataPerusahaanMisi CreateMisi(string misi)
        { 
            
            return new DataPerusahaanMisi(misi);
        }
        private DataPerusahaanMisi( string misi  )
        {
            DataPerusahaanMisiId=Guid.NewGuid();
            Misi=misi;
            TanggalInput=DateTime.Now;
        }

        public Guid DataPerusahaanMisiId { get; set; }
        public string Misi { get; set; }
        public DateTime TanggalInput { get; set; }
        public int NoUrutId { get; set; }
    }
}
