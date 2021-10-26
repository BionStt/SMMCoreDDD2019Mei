using SumberMas2015.SalesMarketing.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain
{
    public class MasterLeasing
    {
        protected MasterLeasing()
        {

        }
        public string NamaLeasing { get; private set; }
        public Guid MasterLeasingId { get; private set; }
        public int NoUrutId { get; set; }
        public static MasterLeasing Create(string namaLeasing)
        {
            var masterLeasing = new MasterLeasing();
            masterLeasing.NamaLeasing = namaLeasing;
            masterLeasing.MasterLeasingId = Guid.NewGuid();
            return masterLeasing;

        }

        private readonly List<MasterLeasingCabang> _listCabangs = new List<MasterLeasingCabang>();
        public IReadOnlyCollection<MasterLeasingCabang> MasterLeasingCabangs => _listCabangs;

        public MasterLeasingCabang AddCabangLeasing(string namaCabang, Guid masterLeasingId, string emailCabang, Alamat alamatCabangLeasing,Guid mstLeasingId)
        {
            var listCabangLeasing = MasterLeasingCabang.Create(namaCabang, emailCabang, alamatCabangLeasing, mstLeasingId);
            _listCabangs.Add(listCabangLeasing);
            return listCabangLeasing;

        }

        public MasterLeasingCabang EditCabangLeasing(Guid masterCabangLeasingId, string namaCabang, string emailCabang, Alamat alamatCabangLeasing)
        {
            var _listCabangLeasing = _listCabangs.FirstOrDefault(i => i.MasterLeasingCabangId == masterCabangLeasingId);
            _listCabangLeasing.EditMasterLeasingCabang(namaCabang, emailCabang, alamatCabangLeasing);
            return _listCabangLeasing;
        }
        public MasterLeasingCabang CabangLeasingDiNonAktifkan(Guid masterCabangLeasingId)
        {
            var _listCabangLeasing = _listCabangs.FirstOrDefault(i => i.MasterLeasingCabangId == masterCabangLeasingId);
            _listCabangLeasing.MarkAsNonAktif();
            return _listCabangLeasing;
        }


    }
}
