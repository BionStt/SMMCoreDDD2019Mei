﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.DataKontrakAsuransiDBs.Command.DeleteDataKontrakAsuransi
{
    public class DeleteDataKontrakAsuransiCommand:IRequest
    {
        public int Id { get; set; }
    }
}
