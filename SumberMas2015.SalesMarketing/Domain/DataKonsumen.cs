﻿
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

        public DateTime CreatedAt { get; private set; }

        public Guid JenisKelaminId { get; private set; }
        public Guid AgamaId { get; private set; }
        public JenisKelamin JenisKelamin { get; private set; }
        public Agama Agama { get; private set; }
        protected DataKonsumen()
        {

        }

        private DataKonsumen(string noKTP, DateTime tanggalLahir, Guid jenisKelaminId, Name nama, Name namaBPKB, Alamat alamatTinggal, Alamat alamatKirim, Guid agamaId, string email)//, DateTime createdAt)
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
           // CreatedAt = createdAt;
        }

        public static DataKonsumen Create(string nomorKTP, DateTime tanggalLahir, Guid jenisKelamin, Name nama, Name namaBpkb, Alamat alamatTinggal, Alamat alamatKirim, Guid agama, string email)
        {
            return new DataKonsumen(nomorKTP, tanggalLahir, jenisKelamin, nama, namaBpkb, alamatTinggal, alamatKirim,agama,email);
        }


    }
}