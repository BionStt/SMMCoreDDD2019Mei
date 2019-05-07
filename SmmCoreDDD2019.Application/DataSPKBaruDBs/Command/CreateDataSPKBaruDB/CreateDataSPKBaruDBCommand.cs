using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;

namespace SmmCoreDDD2019.Application.DataSPKBaruDBs.Command.CreateDataSPKBaruDB
{
    public class CreateDataSPKBaruDBCommand:IRequest
    {
        public int NoUrutSPKBaru { get; set; }
        public string LokasiSpk { get; set; }
        public string Terinput { get; set; }
        public DateTime? TglInput { get; set; }
        public string Tolak { get; set; }
        public int? UserIdpeg { get; set; }
        public string UserInput { get; set; }

        //public ICollection<DataSPKKendaraanDB> DataSPKKendaraanDB { get; set; }
        //public ICollection<DataSPKKreditDB> DataSPKKreditDB { get; set; }
        //public ICollection<DataSPKLeasingDB> DataSPKLeasingDB { get; set; }
        //public ICollection<DataSPKSurveiDB> DataSPKSurveiDB { get; set; }

    }
}
