using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SmmCoreDDD2019.Domain.Entities
{
    public class BPKBDB : BaseEntity
    {
      //  public int NoUrutBPKB { get; set; }
        [Display(Name = "Nama Faktur")]
        public int? PermohonanFakturDBId { get; set; }
        [Display(Name = "No BPKB")]
        public string NoBpkb { get; set; }
        [Display(Name = "Tanggal Terima BPKB")]
        public DateTime? TanggalTerimaBPKB { get; set; }
    }
}
