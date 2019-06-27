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

        public ICollection<DataPegawaiDataKeluarga> DataPegawaiDataKeluarga { get; private set; }
        public ICollection<DataPegawaiDataOrmas> DataPegawaiDataOrmas { get; private set; }

       //   public ICollection<DataPegawaiDataPribadi> DataPegawaiDataPribadi { get; private set; }
       public virtual DataPegawaiDataPribadi DataPegawaiDataPribadi { get; private set; }// mengapa harus inibukan yg diatas ???
        public ICollection<DataPegawaiDataRiwayatPekerjaan> DataPegawaiDataRiwayatPekerjaan { get; private set; }

         public ICollection<DataPegawaiDataRiwayatPelatihan> DataPegawaiDataRiwayatPelatihan { get; private set; }

          public ICollection<DataPegawaiDataRiwayatPendidikan> DataPegawaiDataRiwayatPendidikan  { get; private set; }

          public ICollection<DataPegawaiFoto> DataPegawaiFoto { get; private set; }
    }

}
