using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;

namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPelatihans.Command.UpdateDataPegawaiDataRiwayatPelatihan
{
   public class UpdateDataPegawaiDataRiwayatPelatihanCommand:IRequest
    {
        public int NoUrut { get; set; }
        public int? IDPegawai { get; set; }
        public string NamaLembaga { get; set; }
        public string AlamatLembaga { get; set; }
        public string TelpLembaga { get; set; }
        public string LamaKursus { get; set; }
        public string DibiayaiOleh { get; set; }
        public string BidangPelatihan { get; set; }
        // public DataPegawai DataPegawai { get; set; }
    }
}
