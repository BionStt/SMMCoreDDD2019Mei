using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
   public class DataSPKSurveiDB : BaseEntity
    {
        public static DataSPKSurveiDB CreateDataSPKSurveiDB(string alamatPemesan, string handphonePemesan, string kecamatanPemesan, string kelurahanPemesan, string kodePosPemesan, string kotaPemesan, string namaNPWP, string namaPemesan, string noKtpPemesan, string noNPWP, int? dataSPKBaruDBId, string pekerjaanPemesan, string propinsiPemesan, string telpPemesan)
        {
            return new DataSPKSurveiDB(alamatPemesan,handphonePemesan,kecamatanPemesan,kelurahanPemesan,kodePosPemesan,kotaPemesan,namaNPWP,namaPemesan,noKtpPemesan,noNPWP,dataSPKBaruDBId,pekerjaanPemesan,propinsiPemesan,telpPemesan);
        }
        private DataSPKSurveiDB(string alamatPemesan, string handphonePemesan, string kecamatanPemesan, string kelurahanPemesan, string kodePosPemesan, string kotaPemesan, string namaNPWP, string namaPemesan, string noKtpPemesan, string noNPWP, int? dataSPKBaruDBId, string pekerjaanPemesan, string propinsiPemesan, string telpPemesan)
        {
            AlamatPemesan = alamatPemesan;
            HandphonePemesan = handphonePemesan;
            KecamatanPemesan = kecamatanPemesan;
            KelurahanPemesan = kelurahanPemesan;
            KodePosPemesan = kodePosPemesan;
            KotaPemesan = kotaPemesan;
            NamaNPWP = namaNPWP;
            NamaPemesan = namaPemesan;
            NoKtpPemesan = noKtpPemesan;
            NoNPWP = noNPWP;
            DataSPKBaruDBId = dataSPKBaruDBId;
            PekerjaanPemesan = pekerjaanPemesan;
            PropinsiPemesan = propinsiPemesan;
            TelpPemesan = telpPemesan;
        }
        public void EditDataSPKSurveiDB(string alamatPemesan, string handphonePemesan, string kecamatanPemesan, string kelurahanPemesan, string kodePosPemesan, string kotaPemesan, string namaNPWP, string namaPemesan, string noKtpPemesan, string noNPWP, int? dataSPKBaruDBId, string pekerjaanPemesan, string propinsiPemesan, string telpPemesan)
        {
            AlamatPemesan = alamatPemesan;
            HandphonePemesan = handphonePemesan;
            KecamatanPemesan = kecamatanPemesan;
            KelurahanPemesan = kelurahanPemesan;
            KodePosPemesan = kodePosPemesan;
            KotaPemesan = kotaPemesan;
            NamaNPWP = namaNPWP;
            NamaPemesan = namaPemesan;
            NoKtpPemesan = noKtpPemesan;
            NoNPWP = noNPWP;
            DataSPKBaruDBId = dataSPKBaruDBId;
            PekerjaanPemesan = pekerjaanPemesan;
            PropinsiPemesan = propinsiPemesan;
            TelpPemesan = telpPemesan;
        }
        // public int NoUrut { get; set; }
        public string AlamatPemesan { get; private set; }
        public string HandphonePemesan { get; private set; }
        public string KecamatanPemesan { get; private set; }
        public string KelurahanPemesan { get; private set; }
        public string KodePosPemesan { get; private set; }
        public string KotaPemesan { get; private set; }
        public string NamaNPWP { get; private set; }
        public string NamaPemesan { get; private set; }
        public string NoKtpPemesan { get; private set; }
        public string NoNPWP { get; private set; }
        public int? DataSPKBaruDBId{ get; private set; }
        public string PekerjaanPemesan { get; private set; }
        public string PropinsiPemesan { get; private set; }
        public string TelpPemesan { get; private set; }



    }
}
