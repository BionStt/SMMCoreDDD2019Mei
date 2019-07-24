using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Application.ViewModels.AccountingDataAccount
{
    public class AccountingDataAccountViewModel
    {
        // public int NoUrutAccountId { get; set; }
        // public int Lft { get; set; }
        //  public int Rgt { get; set; }
        public string Parent { get; set; }
        //  public int Depth { get; set; }
        [Display(Name = "Kode Akun")]
        public string KodeAccount { get; set; }
        [Display(Name = "Nama Akun")]
        public string Account { get; set; }
        [Display(Name = "Normal Pos")]
        public int NormalPos { get; set; }
        [Display(Name = "Kelompok")]
        public string Kelompok { get; set; }
        [Display(Name = "Mata Uang")]
        public int AccountingDataMataUangId { get; set; }

    }
}
