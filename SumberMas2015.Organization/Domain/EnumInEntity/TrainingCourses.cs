using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.Domain.EnumInEntity
{
    public class TrainingCourses
    {
        public Guid TrainingCoursesId { get; set; }
        public string NamaTraining { get; set; }
        public string Keterangan { get; set; }

        public int NoUrutId { get; set; }

    }
}
