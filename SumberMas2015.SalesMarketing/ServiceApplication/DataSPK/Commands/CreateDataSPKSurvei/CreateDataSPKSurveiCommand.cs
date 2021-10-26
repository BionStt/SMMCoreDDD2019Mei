﻿using MediatR;
using SumberMas2015.SalesMarketing.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Commands.CreateDataSPKSurvei
{
    public class CreateDataSPKSurveiCommand:IRequest<Guid>
    {
        public string NoKTPPemesan { get; set; }
        public Name NamaPemesan { get; set; }
        public Alamat AlamatPemesan{ get; set; }
        public DataNPWP DataNPWPPemesan { get; set; }
        public string PekerjaanPemesan { get; set; }
        public int DataSPKId { get; set; }



    }
}