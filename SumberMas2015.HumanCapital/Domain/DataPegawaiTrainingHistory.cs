using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.HumanCapital.Domain
{
    public class DataPegawaiTrainingHistory
    {
        public Guid DataPegawaiTrainingHistoryId { get; set; }

        public Guid TrainingCoursesId { get; set; }

        public DateTime TanggalMengikutiTraining { get; set; }

    }
}
