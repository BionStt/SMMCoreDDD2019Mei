﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumberMas2015.SalesMarketing.Domain.ValueObjects;

namespace SumberMas2015.SalesMarketing.Domain
{
    public class PermohonanFaktur
    {
        protected PermohonanFaktur()
        {

        }

        public static PermohonanFaktur CreatePermohonanFaktur(string noRegistrasiFaktur, DateTime? tanggalMohonFaktur, Guid penjualanDetailId, DateTime? tanggalLahir, string nomorKTP, string namaFaktur, Alamat alamatFaktur)
        {
            return new PermohonanFaktur(noRegistrasiFaktur,tanggalMohonFaktur,penjualanDetailId,tanggalLahir,nomorKTP,namaFaktur,alamatFaktur);
        }
        private PermohonanFaktur(string noRegistrasiFaktur, DateTime? tanggalMohonFaktur, Guid penjualanDetailId, DateTime? tanggalLahir, string nomorKTP, string namaFaktur, Alamat alamatFaktur)
        {
            PermohonanFakturId = Guid.NewGuid();
            NoRegistrasiFaktur = noRegistrasiFaktur;
            TanggalMohonFaktur = tanggalMohonFaktur;
            PenjualanDetailId = penjualanDetailId;
            TanggalLahir = tanggalLahir;
            NomorKTP = nomorKTP;
            NamaFaktur = namaFaktur;
            AlamatFaktur = alamatFaktur;
        }

        public Guid PermohonanFakturId { get; set; }


        public string NoRegistrasiFaktur { get; set; }
        public DateTime? TanggalMohonFaktur { get; set; }
        public Guid PenjualanDetailId { get; set; }
        public DateTime? TanggalLahir { get; set; }
        public string NomorKTP { get; set; }
        public string NamaFaktur { get; set; }
        public Alamat AlamatFaktur{ get; set; }
        public int NoUrutId { get; set; }



    }
}
