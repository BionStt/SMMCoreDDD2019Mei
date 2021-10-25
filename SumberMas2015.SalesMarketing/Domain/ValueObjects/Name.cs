
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain.ValueObjects
{
    public class Name
    {
        [Display(Name = "Nama Depan", Prompt = "Masukan nama nama depan")]
        public string NamaDepan { get; }
        [Display(Name = "Nama Belakang", Prompt = "Masukan nama nama belakang")]
        public string NamaBelakang { get; }
        protected Name()
        {

        }

        private Name(string namaDepan, string namaBelakang)
        {
            if (string.IsNullOrWhiteSpace(namaDepan)) throw new ArgumentException("Nama Depan tidak bisa kosong");

            if (string.IsNullOrWhiteSpace(namaBelakang)) throw new ArgumentException("Nama Belakang tidak bisa  kosong");

            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
        }
        public static Name CreateName(string namaDepan, string namaBelakang)
        {
            return new Name(namaDepan, namaBelakang);
        }


    }
}
