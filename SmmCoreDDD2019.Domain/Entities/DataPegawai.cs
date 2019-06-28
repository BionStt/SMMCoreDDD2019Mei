using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Domain.Entities
{
    public   class DataPegawai : BaseEntity
    {
      //  public int IDPegawai { get; set; }
        public string ApplicationUserId { get; set; }
        public String NoRegistrasiPegawai { get; set; }
        public DateTime? TglInput { get; set; }
     
        public DateTime? TglMulaiKerja { get; set; }
    
        public DateTime? TglBerhentiKerja { get; set; }
        public string Aktif { get; set; }

        public DataPegawaiDataRiwayatPelatihan DataPegawaiDataRiwayatPelatihan { get; set; }
        public DataPegawaiDataAbsensi DataPegawaiDataAbsensi { get; set; }
        public DataPegawaiDataAward DataPegawaiDataAward { get; set; }
        public DataPegawaiDataJabatan DataPegawaiDataJabatan { get; set; }
        public DataPegawaiDataKeluarga DataPegawaiDataKeluarga { get; set; }
        public DataPegawaiDataOrmas DataPegawaiDataOrmas { get; set; }
        public DataPegawaiDataPribadi DataPegawaiDataPribadi { get; set; }
        public DataPegawaiDataRiwayatPekerjaan DataPegawaiDataRiwayatPekerjaan { get; set; }
        public DataPegawaiDataRiwayatPendidikan DataPegawaiDataRiwayatPendidikan { get; set; }
        public DataPegawaiFoto DataPegawaiFoto { get; set; }

     }

}
