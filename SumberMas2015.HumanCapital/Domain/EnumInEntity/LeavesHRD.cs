using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.HumanCapital.Domain.EnumInEntity
{
    public class LeavesHRD
    {
        public Guid LeavesHRDId { get; set; }
        public string LeaveName { get; set; }
        public string? JumlahHariCuti { get; set; }
        public string? Status { get; set; }

        public int NoUrutId { get; set; }

        //        (1, 'Casual Leave', '21', 1),
        //(2, 'Sick Leave', '15', 1),
        //(3, 'Maternity Leave', '90', 1),
        //(4, 'Paternal Leave', '7', 1),
        //(5, 'Earned leave', '', 1),
        //(7, 'Public Holiday', '', 1),
        //(8, 'Optional Leave', '', 1),
        //(9, 'Leave without Pay', '', 1);

        //'name' => 'Cuti Tahunan',
        //        'points' => 100,
        //        'limit' => 12
        //    ],
        //    [
        //        'name' => 'Cuti Alasan Penting',
        //        'points' => 97.5,
        //        'limit' => 60
        //    ],
        //    [
        //        'name' => 'Cuti Bersalin',
        //        'points' => 97.5,
        //        'limit' => 90
        //    ],
        //    [
        //        'name' => 'Cuti Sakit',
        //        'points' => 97.5,
        //        'limit' => 545
        //    ],
        //    [
        //        'name' => 'Cuti Diluar Tanggungan',
        //        'points' => 0,
        //        'limit' => 90

    }
}
