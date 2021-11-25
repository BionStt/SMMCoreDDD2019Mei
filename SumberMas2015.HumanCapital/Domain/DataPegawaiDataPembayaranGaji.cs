using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.HumanCapital.Domain
{
    public class DataPegawaiDataPembayaranGaji
    {
        public Guid DataPegawaiDataPembayaranGajiId { get; set; }
        public int NoUrutId { get; set; }
        public Guid DataPegawaiId { get; set; }
        public DateTime TanggalPembayaran { get; set; }
        public string JumlahHariKerja { get; set; }


              //        `pay_id` int (14) NOT NULL,
              // `emp_id` varchar(64) DEFAULT NULL,
              // `type_id` int (14) NOT NULL,
              //  `month` varchar(64) DEFAULT NULL,
              //  `year` varchar(64) DEFAULT NULL,
              //  `paid_date` varchar(64) DEFAULT NULL,
              //  `total_days` varchar(64) DEFAULT NULL,
              //  `basic` varchar(64) DEFAULT NULL,
              //  `medical` varchar(64) DEFAULT NULL,
              //  `house_rent` varchar(64) DEFAULT NULL,
              //  `bonus` varchar(64) DEFAULT NULL,
              //  `bima` varchar(64) DEFAULT NULL,
              //  `tax` varchar(64) DEFAULT NULL,
              //  `provident_fund` varchar(64) DEFAULT NULL,
              //  `loan` varchar(64) DEFAULT NULL,
              //  `total_pay` varchar(128) DEFAULT NULL,
              //  `addition` int (128) NOT NULL,
              //   `diduction` int (128) NOT NULL,
              //    `status` enum('Paid','Process') DEFAULT 'Process',
              //`paid_type` enum('Hand Cash','Bank') NOT NULL DEFAULT 'Bank'


    }
}
