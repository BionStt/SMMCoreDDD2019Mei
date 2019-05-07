using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Application.BPKBDBs.Command.CreateBPKBDB
{
    public class CreateBPKBDBCommand:IRequest
    {
        [Display(Name = "Nama Faktur")]
        public int? NoUrutFaktur { get; set; }
        [Display(Name = "No BPKB")]
        public string NoBpkb { get; set; }
        [Display(Name = "Tanggal Terima BPKB")]
        public DateTime? TanggalTerimaBPKB { get; set; }
    }
}
