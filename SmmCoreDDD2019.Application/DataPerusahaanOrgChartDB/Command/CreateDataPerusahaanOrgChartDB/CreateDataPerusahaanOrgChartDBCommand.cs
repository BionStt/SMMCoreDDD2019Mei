
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MediatR;


namespace SmmCoreDDD2019.Application.DataPerusahaanOrgChartDB.Command.CreateDataPerusahaanOrgChartDB
{
    public class CreateDataPerusahaanOrgChartDBCommand:IRequest
    {
        public int NoUrutStrukturID { get; set; }
        //public int Lft { get; set; }
        //public int Rgt { get; set; }
        [Display(Name = "Parent")]
        public string Parent { get; set; }

        //public int Depth { get; set; }
        [Display(Name = "Kode Struktur Organisasi")]
        public string KodeStrukturJabatan { get; set; }
        [Display(Name = "Nama Jabatan")]
        public string NamaStrukturJabatan { get; set; }
    }
}
