using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Commands.CreateDataSPKKendaraan
{
    public class CreateDataSPKKendaraanCommand:IRequest<Guid>
    {
        public int DataSPKId { get; set; }
        public string TahunPerakitan { get; set; }
        public string Warna { get; set; }
        public string NamaSTNK { get; set; }
        public int MasterBarangId { get; set; }
        public string NoKTPSTNK { get; set; }
    }
}
