using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Blazor.Shared.Dto.JenisKelamin
{
    public class ListJenisKelaminResponse
    {
        public Guid ListJenisKelaminResponseId { get; set; }
        public int NoUrutId { get; set; }
        public string JenisKelaminKeterangan { get; set; }
    }
}
