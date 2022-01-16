using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.Domain
{
    public class MasterBarang
    {
        public Guid MasterBarangId { get; set; }
        public string NamaBarang { get; private set; }
        public string NomorRangka { get; private set; }
        public string NomorMesin { get; private set; }
        public string Merek { get; private set; }
        public string KapasitasMesin { get; private set; }
        public decimal? HargaOff { get; private set; }
        public decimal? Bbn { get; private set; }
        public string TahunPerakitan { get; private set; }
        public string TypeKendaraan { get; private set; }
        public int MasterBarangStatus { get; private set; }
        public int NoUrutId { get; set; }
        public string UserName { get; set; }
        public Guid UserNameId { get; set; }
        public void NonAktifStatusMasterBarang()
        {
            MasterBarangStatus = 0;
        }
        protected MasterBarang()
        {

        }
        private MasterBarang(string namaBarang, string nomorRangka, string nomorMesin, string merek, string kapasitasMesin, decimal? hargaOff, decimal? bbn, string tahunPerakitan, string typeKendaraan, string userName, Guid userNameId, Guid masterBarangId)
        {

            NamaBarang = namaBarang;
            NomorRangka = nomorRangka;
            NomorMesin = nomorMesin;
            Merek = merek;
            KapasitasMesin = kapasitasMesin;
            HargaOff = hargaOff;
            Bbn = bbn;
            TahunPerakitan = tahunPerakitan;
            TypeKendaraan = typeKendaraan;
            MasterBarangStatus = 0;
            UserName=userName;
            UserNameId=userNameId;
            MasterBarangId=masterBarangId;
        }
        public static MasterBarang Create(string namaBarang, string nomorRangka, string nomorMesin, string merek, string kapasitasMesin, decimal? hargaOff, decimal? bbn, string tahunPerakitan, string typeKendaraan, string userName, Guid userNameId,Guid masterBarangId)
        {
            return new MasterBarang(namaBarang, nomorRangka, nomorMesin, merek, kapasitasMesin, hargaOff, bbn, tahunPerakitan, typeKendaraan,userName,userNameId, masterBarangId);
        }
        public void EditMasterBarang(string namaBarang, string nomorRangka, string nomorMesin, string merek, string kapasitasMesin, decimal? hargaOff, decimal? bbn, string tahunPerakitan, string typeKendaraan)
        {
            NamaBarang = namaBarang;
            NomorRangka = nomorRangka;
            NomorMesin = nomorMesin;
            Merek = merek;
            KapasitasMesin = kapasitasMesin;
            HargaOff = hargaOff;
            Bbn = bbn;
            TahunPerakitan = tahunPerakitan;
            TypeKendaraan = typeKendaraan;
        }

        //public enum MasterBarangStatus
        //{
        //    Aktif = 0,
        //    TidakAktif = 1

        //}
    }
}
