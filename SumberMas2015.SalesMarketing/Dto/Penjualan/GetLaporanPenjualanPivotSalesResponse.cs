﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Dto.Penjualan
{
    public class GetLaporanPenjualanPivotSalesResponse
    {
        public string NamaSales { get; set; }
        public int HONDA { get; set; }
        public int YAMAHA { get; set; }
        public int SUZUKI { get; set; }
        public int KAWASAKI { get; set; }
        public int TtlRow { get; set; }
        public int KodePenjualanID { get; set; }

    }
}
