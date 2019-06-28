using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class MasterLeaveTypeHRD : BaseEntity
    {
       // [Key]
       // public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsDelete { get; set; }
        [Required]
        [DisplayName("Leave Type Name")]
        public string LeaveTypeName { get; set; }
    }
}
