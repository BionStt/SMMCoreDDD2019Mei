using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.HumanCapital.Domain
{
    public class DataPegawaiSalaryType
    {
        public Guid DataPegawaiSalaryTypeId { get; set; }
        public int NoUrutId { get; set; }
        public string SalaryType { get; set; }
        public DateTime CreatedDate { get; set; }

        //        CREATE TABLE `salary_type` (
        //  `id` int (14) NOT NULL,
        //   `salary_type` varchar(256) DEFAULT NULL,
        //   `create_date` varchar(256) DEFAULT NULL
        //) ENGINE=InnoDB DEFAULT CHARSET=utf8;

        //--
        //-- Dumping data for table `salary_type`
        //--

        //INSERT INTO `salary_type` (`id`, `salary_type`, `create_date`) VALUES
        //(1, 'Hourly', '2017-11-22'),
        //(2, 'Monthly', '2017-12-30'),
        //(3, 'hhfgf', '2017-12-29'),
        //(4, 'Hourly', '2018-03-31');

    }
}
