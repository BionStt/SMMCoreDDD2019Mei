using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Application.MasterLeasingDbs.Commands.CreateMasterLeasingDb
{
   public class CreateMasterLeasingDbCommand:IRequest
    {

      //  public int IDlease { get; set; }
        [Display(Name = "Nama Leasing")]
        public string NamaLease { get; set; }
     //   public ICollection<MasterLeasingCabangDB> MasterLeasingCabangDB { get; private set; }
    }
}
