﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Dto.MasterBarang
{
    public class MasterBarangByIdResponse
    {
        public int NoUrutId { get;  set; }
        public string NamaBarang { get; set; }
        public Guid MasterBarangIdGuid { get; set; }
    }
}
