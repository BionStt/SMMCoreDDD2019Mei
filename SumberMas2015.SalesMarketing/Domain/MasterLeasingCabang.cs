
using SumberMas2015.SalesMarketing.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain
{
    public class MasterLeasingCabang
    {
        public Guid MasterLeasingCabangId { get; set; }
        public string NamaCabang { get; private set; }
        public string EmailCabang { get; private set; }
        public int Status { get; private set; }
        public int NoUrutId { get; private set; }
        public Alamat AlamatCabangLeasing { get; private set; }

      //  public Guid MasterLeasingId { get; private set; }
        public MasterLeasing MasterLeasing { get; private set; }
        //public enum LeasingCabangStatus
        //{
        //    TidakAktif = 0,
        //    Aktif = 1
        //}
        protected MasterLeasingCabang()
        {

        }
        public static MasterLeasingCabang Create(string namaCabang, string emailCabang, Alamat alamatCabangLeasing)
        {
            return new MasterLeasingCabang(namaCabang, emailCabang, alamatCabangLeasing);
        }

        private MasterLeasingCabang(string namaCabang, string emailCabang, Alamat alamatCabangLeasing)
        {
            MasterLeasingCabangId = Guid.NewGuid();
            // MasterLeasingId = masterLeasingId;
            NamaCabang = namaCabang;
            EmailCabang = emailCabang;
            Status = 1;
            AlamatCabangLeasing = alamatCabangLeasing;
        }
        public void EditMasterLeasingCabang(string namaCabang, string emailCabang, Alamat alamatCabangLeasing)
        {
            NamaCabang = namaCabang;
            EmailCabang = emailCabang;
            AlamatCabangLeasing = alamatCabangLeasing;
        }

        public void MarkAsNonAktif()
        {
            Status = 0;

        }


    }
}
