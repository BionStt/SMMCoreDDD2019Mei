using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Common.Identity
{
    public class NumberSequence
    {
        public int NumberSequenceId { get; set; }
        [Required]
        public string NumberSequenceName { get; set; }
        [Required]
        public string Module { get; set; }
        [Required]
        public string Prefix { get; set; }
        public int LastNumber { get; set; }
    }
}
