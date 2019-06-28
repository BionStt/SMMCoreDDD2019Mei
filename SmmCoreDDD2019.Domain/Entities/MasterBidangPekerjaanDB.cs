using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class MasterBidangPekerjaanDB : BaseEntity
    {
       // public int NoKodeMasterBidangPekerjaan { get; set; }
        public string NamaMasterBidangPekerjaan { get; set; }
        public DateTime TanggalInput { get; set; }
    }
}
