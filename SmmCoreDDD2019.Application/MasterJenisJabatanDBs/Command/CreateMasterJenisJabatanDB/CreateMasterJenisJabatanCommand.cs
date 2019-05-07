using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

using MediatR;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
using SmmCoreDDD2019.Application.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Application.MasterJenisJabatanDBs.Command.CreateMasterJenisJabatanDB
{
    public class CreateMasterJenisJabatanCommand:IRequest
    {
        [Display(Name = "Nama Jabatan")]
        public string NamaJabatan { get; set; }
    }
}
