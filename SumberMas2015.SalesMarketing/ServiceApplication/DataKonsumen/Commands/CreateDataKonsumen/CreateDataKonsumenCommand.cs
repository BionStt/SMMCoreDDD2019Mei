using MediatR;
using SumberMas2015.SalesMarketing.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataKonsumen.Commands.CreateDataKonsumen
{
    public class CreateDataKonsumenCommand:IRequest<Guid>
    {
        public Name Nama { get; set; }
        public Alamat Alamat { get; set; }
        public int JenisKelamin { get; set; }
        public Alamat AlamatKirim { get; set; }
        public Name NamaBPKB { get; set; }
        public string NoKtp { get; set; }
        public int Agama { get; set; }
        public DateTime TanggalLahir { get; set; }

        public int KodeBidangPekerjaan { get; set; }

        public string NamaBidangPekerjaan { get; set; }

        public int KodeBidangUsaha { get; set; }

        public string NamaBidangUsaha { get; set; }

        public string Email { get; set; }
        public string UserName { get; set; }

        public Guid UserNameId{ get; set; }
    }
}
