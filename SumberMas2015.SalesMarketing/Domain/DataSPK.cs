﻿
using SumberMas2015.SalesMarketing.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain
{
    public class DataSPK
    {
        private DataSPK(string lokasiSpk, DateTime? tanggalInput, Guid? userId, string userNameInput)
        {
            if (lokasiSpk == null) throw new ArgumentNullException("Lokasi SPK tidak boleh kosong");
            DataSPKId = Guid.NewGuid();
            NoRegistrasiSPK = KodeRegistrasi(DateTime.Now);
            LokasiSpk = lokasiSpk;
            //  Terinput = terinput;
            TanggalInput = tanggalInput;
            //  Tolak = tolak;
            UserId = userId;
            UserNameInput = userNameInput;
            StatusSPK = 0;
        }
        public static DataSPK CreateDataSPKBaru(string lokasiSpk,  DateTime? tanggallInput,  Guid? userId, string userNameInput)
        {
            return new DataSPK(lokasiSpk, tanggallInput, userId,userNameInput);
        }
        private void Ditolak()
        {
            Tolak = "1";
        }
        public enum StatusInputSPK
        {
            Disurvei = 0,
            DiAcc = 1,
            Ditolaks = 2
        }


        private string KodeRegistrasi(DateTime Tanggal)
        {
              var NoRegistrasiSPK = string.Format("{0}{1}{2}{3}", Tanggal.Year.ToString(), Tanggal.Month.ToString(), DateTime.UtcNow.Date.Day.ToString(), Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGSPK");

            //var NoRegistrasiSPK = DateTime.UtcNow.Date.Year.ToString() +
            //  DateTime.UtcNow.Date.Month.ToString() +
            //  DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGSPK";

            return NoRegistrasiSPK;

        }
        private string GenerateId(int travelerId, DateTime firstNight, DateTime lastNight, DateTime booked)
        {
            return string.Format(
                "{0}-{1}-{2}-{3}",
                travelerId, ToIdFormat(firstNight), ToIdFormat(lastNight), ToIdFormat(booked)
            );
        }

        private string ToIdFormat(DateTime date)
        {
            return date.ToString("yyyy/MM/dd");
        }

        protected DataSPK()
        {

        }
        public Guid DataSPKId { get; set; }
        public string NoRegistrasiSPK { get; private set; }
        public string LokasiSpk { get; private set; }

       public int StatusSPK { get; private set; }

        public DateTime? TanggalInput { get; private set; }
        public string Tolak { get; private set; }
        public Guid? UserId { get; private set; }
        public string? UserNameInput { get; private set; }
        public int NoUrutId { get; set; }

        private readonly List<DataSPKSurvei> _dataSPKSurvei = new List<DataSPKSurvei>();
        public IReadOnlyCollection<DataSPKSurvei> DataSPKSurvei => _dataSPKSurvei.AsReadOnly();

        public DataSPKSurvei AddDataSPKSurvei(string noKTPPemesan, Name namaPemesan, Alamat alamatPemesan, DataNPWP dataNPWPPemesan, string pekerjaanPemesan)
        {
            var DtSPKSurvei = new DataSPKSurvei(noKTPPemesan, namaPemesan, alamatPemesan, dataNPWPPemesan, pekerjaanPemesan);
            _dataSPKSurvei.Add(DtSPKSurvei);
            return DtSPKSurvei;
        }
        public DataSPKSurvei EditDataSPKSurvei(string noKTPPemesan, Name namaPemesan, Alamat alamatPemesan, DataNPWP dataNPWPPemesan, string pekerjaanPemesan, Guid DataSpkSurveiId)
        {
            var dataSPKSurvei = _dataSPKSurvei.FirstOrDefault(i => i.Id == DataSpkSurveiId);
            dataSPKSurvei.EditDataSPKSurvei(noKTPPemesan, namaPemesan, alamatPemesan, dataNPWPPemesan, pekerjaanPemesan);
            return dataSPKSurvei;
        }

        private readonly List<DataSPKLeasing> _dataSpkLeasing = new List<DataSPKLeasing>();
        public IReadOnlyCollection<DataSPKLeasing> DataSPKLeasing => _dataSpkLeasing.AsReadOnly();

        public DataSPKLeasing AddDataSPKLeasing(decimal? angsuran, string mediator, string namaCmo, Guid namaSales, int? tenor, DateTime? tanggalSurvei)
        {
            var dataSpkLeasing = new DataSPKLeasing(angsuran, mediator, namaCmo, namaSales, tenor);
            _dataSpkLeasing.Add(dataSpkLeasing);
            return dataSpkLeasing;
        }
        public DataSPKLeasing EditDataSpkLeasing(decimal? angsuran, string mediator, string namaCmo, Guid namaSales, int? tenor, DateTime? tanggalSurvei, Guid DataSPKLEasingId)
        {
            var dataSpkLeasing = _dataSpkLeasing.FirstOrDefault(i => i.Id == DataSPKLEasingId);
            dataSpkLeasing.EditDataSpkLeasing(angsuran, mediator, namaCmo, namaSales, tenor, tanggalSurvei);
            return dataSpkLeasing;
        }

        private readonly List<DataSPKKredit> _dataSpkKredit = new List<DataSPKKredit>();
        public IReadOnlyCollection<DataSPKKredit> DataSPKKredit => _dataSpkKredit.AsReadOnly();
        public DataSPKKredit AddDataSPKKredit(decimal? biayaAdministrasiKredit, decimal? biayaAdministrasiTunai, decimal? bBN, decimal? dendaWilayah, decimal? diskonDP, decimal? diskonTunai, decimal? dPPriceList, decimal? komisi, decimal? offTheRoad, decimal? promosi, decimal? uangTandaJadiTunai, decimal? uangTandaJadiKredit)
        {
            var dataSPKKredit = new DataSPKKredit(biayaAdministrasiKredit, biayaAdministrasiTunai, bBN, dendaWilayah, diskonDP, diskonTunai, dPPriceList, komisi, offTheRoad, promosi, uangTandaJadiTunai, uangTandaJadiKredit);
            _dataSpkKredit.Add(dataSPKKredit);
            return dataSPKKredit;
        }
        public DataSPKKredit EditDataSPKKredit(decimal? biayaAdministrasiKredit, decimal? biayaAdministrasiTunai, decimal? bBN, decimal? dendaWilayah, decimal? diskonDP, decimal? diskonTunai, decimal? dPPriceList, decimal? komisi, decimal? offTheRoad, decimal? promosi, decimal? uangTandaJadiTunai, decimal? uangTandaJadiKredit, Guid DataSpkKreditId)
        {
            var dataspkKredit = _dataSpkKredit.FirstOrDefault(i => i.Id == DataSpkKreditId);
            dataspkKredit.EditDataSPKKredit(biayaAdministrasiKredit, biayaAdministrasiTunai, bBN, dendaWilayah, diskonDP, diskonTunai, dPPriceList, komisi, offTheRoad, promosi, uangTandaJadiTunai, uangTandaJadiKredit);
            return dataspkKredit;

        }

    }
}