using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.HumanCapital.Domain.EnumInEntity
{
    public class JenisKelamin
    {
        protected JenisKelamin()
        {

        }
        private JenisKelamin(string jenisKelaminKeterangan)
        {
            JenisKelaminId = Guid.NewGuid();
            JenisKelaminKeterangan = jenisKelaminKeterangan;
        }
        public static JenisKelamin AddJenisKelamin(string jenisKelaminKeterangan)
        {
            return new JenisKelamin(jenisKelaminKeterangan);
        }
        public String JenisKelaminKeterangan { get; set; }
        public Guid JenisKelaminId { get; set; }
        public int NoUrutId { get; set; }


    }
}
