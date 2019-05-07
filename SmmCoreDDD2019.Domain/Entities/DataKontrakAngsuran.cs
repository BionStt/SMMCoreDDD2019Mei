using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class DataKontrakAngsuran
    {
        public int NoUrutDataAngsuran { get; set; }
        public string NoRegisterKontrakKredit { get; set; }
        public int? AngsuranKe { get; set; }
        public string NoKwitansi { get; set; }
        public DateTime? TanggalAngsuran { get; set; }
        public double? Angsuran { get; set; }
        public double? Pokok { get; set; }
        public double? Bunga { get; set; }
        public double? SisaPokok { get; set; }
        public double? SisaBunga { get; set; }
        public double? Denda { get; set; }
        public double? DiskonDenda { get; set; }
        public double? TitipanAngsuran { get; set; }
        public DateTime? TanggalBayarAngsuran { get; set; }
        public double? JumlahPembayaran { get; set; }
        public int? CaraBayar { get; set; }
        public double? BiayaAdministrasi { get; set; }
        public string PenagihId { get; set; }
    }
}
