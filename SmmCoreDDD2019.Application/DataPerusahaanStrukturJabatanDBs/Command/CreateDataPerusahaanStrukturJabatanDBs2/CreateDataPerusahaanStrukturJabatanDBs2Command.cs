using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDBs.Command.CreateDataPerusahaanStrukturJabatanDBs2
{
    public class CreateDataPerusahaanStrukturJabatanDBs2Command : IRequest
    {
        public int NoUrutStrukturID { get; set; }
        //public int Lft { get; set; }
        //public int Rgt { get; set; }
        [Display(Name = "Parent")]
        public string Parent { get; set; }

        //public int Depth { get; set; }
        [Display(Name = "Kode Struktur Organisasi")]
        public string KodeStruktur { get; set; }
        [Display(Name = "Nama Jabatan")]
        public string NamaStrukturJabatan { get; set; }
    }
}
