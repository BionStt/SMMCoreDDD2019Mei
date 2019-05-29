﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.Penjualans.Query.GetDataPenjualanBulananBySales
{
    public class GetDataPenjualanBulananBySalesQuery : IRequest<GetDataPenjualanBulananBySalesViewModel>
    {
        public DateTime PeriodeAwal { get; set; }
        public DateTime PeriodeAkhir { get; set; }
        public string NoUrutSales { get; set; }
    }
}