using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.MasterLeaveTypeHRDDB.Command.CreateMasterLeaveTypeHRD
{
    public class CreateMasterLeaveTypeHRDCommand : IRequest
    {
        //[Key]
       // public int Id { get; set; }
       // public DateTime CreateDate { get; set; }
       // public DateTime UpdateDate { get; set; }
        //public bool IsDelete { get; set; }
        [Required]
        [DisplayName("Leave Type Name")]
        public string LeaveTypeName { get; set; }
    }
}
