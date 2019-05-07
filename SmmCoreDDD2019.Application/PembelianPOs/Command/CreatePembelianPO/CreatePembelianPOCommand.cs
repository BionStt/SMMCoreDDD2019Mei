using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
using System.ComponentModel.DataAnnotations;
namespace SmmCoreDDD2019.Application.PembelianPOs.Command.CreatePembelianPO
{
    public class CreatePembelianPOCommand : IRequest
    {
        [Display(Name = "Nama Supplier")]
      public int? NoDealer { get; set; }
        [Display(Name = "Keterangan")]
        public string Keterangan { get; set; }
        [Display(Name = "User ID")]
        public int? UserId { get; set; }
        [Display(Name = "User Input")]
        public string UserInput { get; set; }
        [Display(Name = "PO ASTRA")]
        public string PoAstra { get; set; }
    }
}
