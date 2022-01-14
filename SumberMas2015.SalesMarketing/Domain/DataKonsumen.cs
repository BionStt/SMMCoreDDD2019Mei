using SumberMas2015.SalesMarketing.Domain.EnumInEntity;
using SumberMas2015.SalesMarketing.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain
{
    public class DataKonsumen
    {
        public Guid DataKonsumenId { get; set; }
        public int NoUrutId { get; set; }
        public string NoKTP { get; private set; }
        public DateTime TanggalLahir { get; private set; }


        public Name Nama { get; private set; }
        public Name NamaBPKB { get; private set; }
        public Alamat AlamatTinggal { get; private set; }
        public Alamat AlamatKirim { get; private set; }
        public string Email { get; private set; }
        public Guid KodeBidangPekerjaan { get; set; }
        public string NamaBidangPekerjaan { get; set; }
        public Guid KodeBidangUsaha { get; set; }
        public string NamaBidangUsaha { get; set; }
        public DateTime CreatedAt { get; private set; }

        public Guid JenisKelaminId { get; private set; }
        public Guid AgamaId { get; private set; }
        public string Terinput { get; set; }
        public string UserName { get; set; }
        public Guid UserNameId { get; set; }

        protected DataKonsumen()
        {

        }

        private DataKonsumen(string noKTP, DateTime tanggalLahir, Guid jenisKelaminId, Name nama, Name namaBPKB, Alamat alamatTinggal, Alamat alamatKirim, Guid agamaId, string email, Guid kodeBidangPekerjaan, string namaBidangPekerjaan, Guid kodeBidangUsaha, string namaBidangUsaha, string userName, Guid userNameId)//, DateTime createdAt)
        {
            DataKonsumenId = Guid.NewGuid();
            CreatedAt = DateTime.Now.Date;
            NoKTP = noKTP;
            TanggalLahir = tanggalLahir;
            JenisKelaminId = jenisKelaminId;
            Nama = nama;
            NamaBPKB = namaBPKB;
            AlamatTinggal = alamatTinggal;
            AlamatKirim = alamatKirim;
            AgamaId = agamaId;
            Email = email;
            KodeBidangPekerjaan = kodeBidangPekerjaan;
            NamaBidangPekerjaan = namaBidangPekerjaan;
            KodeBidangUsaha = kodeBidangUsaha;
            NamaBidangUsaha = namaBidangUsaha;
            UserName=userName;
            UserNameId=userNameId;
            // CreatedAt = createdAt;
        }
        public void SetBidangPekerjaan(Guid kodeBidangPekerjaan,string namaBidangPekerjaan)
        {
            KodeBidangPekerjaan=kodeBidangPekerjaan;
            NamaBidangPekerjaan=namaBidangPekerjaan;
        }
        public void SetBidangUsaha(Guid kodeBidangUsaha, string namaBidangUsaha)
        {
            KodeBidangUsaha =kodeBidangUsaha;
            NamaBidangUsaha = namaBidangUsaha;
        }
        public void SetUserNameId(string userName, Guid userNameId)
        {
            userName = userName;
            UserNameId = userNameId;
        }
        public static DataKonsumen Create(string nomorKTP, DateTime tanggalLahir, Guid jenisKelamin, Name nama, Name namaBpkb, Alamat alamatTinggal, Alamat alamatKirim, Guid agama, string email, Guid kodeBidangPekerjaan, string namaBidangPekerjaan, Guid kodeBidangUsaha, string namaBidangUsaha, string userName, Guid userNameId)
        {
            return new DataKonsumen(nomorKTP, tanggalLahir, jenisKelamin, nama, namaBpkb, alamatTinggal, alamatKirim,agama,email,kodeBidangPekerjaan,namaBidangPekerjaan,kodeBidangUsaha,namaBidangUsaha,userName,userNameId);
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
        public void SetNama(string namaDepan,string namaBelakang,string namaDepanBPKB, string namaBelakangBPKB)
        {

            Nama = Domain.ValueObjects.Name.CreateName(namaDepan, namaBelakang);
            NamaBPKB = Domain.ValueObjects.Name.CreateName(namaDepanBPKB, namaBelakangBPKB);

        }
        public void SetTanggalLahirJenisKelamin(DateTime tanggalLahir,Guid jenisKelamin)
        {
            TanggalLahir = tanggalLahir;
            JenisKelaminId = JenisKelaminId;
        }
        public void SetAlamatKirim(string jalan,string kelurahan,string kecamatan,string kota,string propinsi,string kodepos,string notelepon,string nofax,string nohandphone)
        {
            AlamatKirim = Domain.ValueObjects.Alamat.CreateAlamat(jalan,kelurahan,kecamatan,kota,propinsi,kodepos,notelepon,nofax,nohandphone);
        }
        public void SetAlamatTinggal(string jalan, string kelurahan, string kecamatan, string kota, string propinsi, string kodepos, string notelepon, string nofax, string nohandphone)
        {
            AlamatTinggal = Domain.ValueObjects.Alamat.CreateAlamat(jalan, kelurahan, kecamatan, kota, propinsi, kodepos, notelepon, nofax, nohandphone);
        }
    }
}
