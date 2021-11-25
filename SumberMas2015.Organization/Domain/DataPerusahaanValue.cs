using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.Domain
{
    public class DataPerusahaanValue
    {
        public static DataPerusahaanValue CreateValue(string valuePerusahaan)
        {
            return new DataPerusahaanValue(valuePerusahaan);
        }
        private DataPerusahaanValue( string valuePerusahaan  )
        {
            DataPerusahaanValueId=Guid.NewGuid();
            ValuePerusahaan=valuePerusahaan;
            TanggalInput=DateTime.Now;
        }

        public Guid DataPerusahaanValueId { get; set; }
        public string ValuePerusahaan { get; set; }
        public DateTime TanggalInput { get; set; }
        public int NoUrutId { get; set; }
    }
}
