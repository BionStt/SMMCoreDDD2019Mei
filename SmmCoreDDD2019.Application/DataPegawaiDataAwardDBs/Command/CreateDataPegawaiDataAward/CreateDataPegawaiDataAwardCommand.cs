using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SmmCoreDDD2019.Application.DataPegawaiDataAwardDBs.Command.CreateDataPegawaiDataAward
{
    public class CreateDataPegawaiDataAwardCommand: IRequest
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsDelete { get; set; }
        [Required]
        [DisplayName("Award Title")]
        public string AwardTitle { get; set; }

        [Required]
        public string Gift { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string Month { get; set; }

        //[ForeignKey("EmployeeModel")]
        [Required]
        public int EmployeeId { get; set; }
        //  public EmployeeModel EmployeeModel { get; set; }
    }
}
