using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
   public class DataPegawaiDataJabatan : BaseEntity
    {
        //[Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      //  public int NoUrut { get; set; }
     
        public int? DataPegawaiId { get; set; }
      
        public int? MasterJenisJabatanId { get; set; }
      
        public DateTime? TglMenjabat { get; set; }
        public DateTime? TglBerhentiMenjabat { get; set; }
        public string Keterangan { get; set; }
       
    }
}
