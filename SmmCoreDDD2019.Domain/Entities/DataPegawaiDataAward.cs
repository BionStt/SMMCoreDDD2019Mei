using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class DataPegawaiDataAward : BaseEntity
    {
        
      //  public int Id { get; set; }
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
        public int DataPegawaiId { get; set; }
      //  public EmployeeModel EmployeeModel { get; set; }

    }
}
