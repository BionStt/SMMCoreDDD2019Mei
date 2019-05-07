using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;

namespace SmmCoreDDD2019.Application.DataPegawaiDataJabatans.Commands.UpdateDataPegawaiDataJabatan
{
    public class UpdateDataPegawaiDataJabatanCommand:IRequest
    {
        public int NoUrut { get; set; }

        public int? IDPegawai { get; set; }

        public int? NoUrutJabatan { get; set; }

        public DateTime? TglMenjabat { get; set; }
        public DateTime? TglBerhentiMenjabat { get; set; }
        public string Keterangan { get; set; }
        // public MasterJenisJabatan MasterJenisJabatan { get; set; }
    }
}
