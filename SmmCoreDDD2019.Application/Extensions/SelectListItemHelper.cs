using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace SmmCoreDDD2019.Application.Extensions
{
    public class SelectListItemHelper
    {
        public static IEnumerable<SelectListItem> GetSkalaUsaha()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                  new SelectListItem {Text = "USAHA MIKRO", Value = "1"},
                  new SelectListItem {Text = "USAHA KECIL", Value = "2"},
                    new SelectListItem {Text = "USAHA SEDANG", Value = "3"},
                      new SelectListItem {Text = "USAHA BESAR", Value = "4"}
                     
            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetCaraBayar()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                  new SelectListItem {Text = "TUNAI", Value = "1"},
                  new SelectListItem {Text = "TRANFER", Value = "2"},
                    new SelectListItem {Text = "DITAGIH", Value = "3"},
                      new SelectListItem {Text = "ATM", Value = "4"},
                       new SelectListItem {Text = "INDOMARET/ALFAMART", Value = "5"}
            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetPolaAngsuran()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
               new SelectListItem {Text = "Bunga Efektif / Annuitas", Value = "1"},
                 new SelectListItem {Text = "Bunga Flat", Value = "2"}
            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetPernahKredit()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
               new SelectListItem {Text = "YA", Value = "1"},
                 new SelectListItem {Text = "TIDAK", Value = "2"}
            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetAngsuranDimuka()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text="YA",Value="1" },
                 new SelectListItem{Text="TIDAK",Value="2" },
            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetAgamaList()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text="ISLAM",Value="1" },
                 new SelectListItem{Text="KRISTEN KATOLIK",Value="2" },
                  new SelectListItem{Text="KRISTEN PROTESTAN",Value="3" },
                   new SelectListItem{Text="HINDU",Value="4" },
                    new SelectListItem{Text="BUDDHA",Value="5" },
                      new SelectListItem{Text="KONGHUCU",Value="6" },
                 new SelectListItem{Text="ALIRAN KEPERCAYAAN",Value="7" },
                   new SelectListItem{Text="TIDAK JELAS",Value="8" }
            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetJenisKelaminList()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "PRIA", Value = "1"},
                new SelectListItem{Text = "WANITA", Value = "2"},
                new SelectListItem{Text = "TIDAK JELAS", Value = "3"}

            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetPendidikanTerakhir()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "TK", Value = "1"},
                new SelectListItem{Text = "SD", Value = "2"},
                new SelectListItem{Text = "SMP", Value = "3"},
                   new SelectListItem{Text = "SMA", Value = "4"},
                new SelectListItem{Text = "UNIVERSITAS", Value = "5"},
                new SelectListItem{Text = "TIDAK SEKOLAH", Value = "6"}

            };
            return items;
        }

        public static IEnumerable<SelectListItem> GetEmergencyCall()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "YA", Value = "Y"},
                new SelectListItem{Text = "TIDAK", Value = "T"}


            };
            return items;
        }

        public static IEnumerable<SelectListItem> GetStatusMenikah()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "LAJANG", Value = "1"},
                new SelectListItem{Text = "MENIKAH", Value = "2"},
                new SelectListItem{Text = "DUDA", Value = "3"},
                  new SelectListItem{Text = "JANDA", Value = "4"},
                    new SelectListItem{Text = "CERAI MATI", Value = "5"}
            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetStatusTempatTinggal()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "RUMAH ORANG TUA", Value = "1"},
                new SelectListItem{Text = "RUMAH SENDIRI", Value = "2"},
                new SelectListItem{Text = "KOST", Value = "3"},
                  new SelectListItem{Text = "RUKO KONTRAKAN", Value = "4"},
                    new SelectListItem{Text = "RUMAH KONTRAKAN", Value = "5"},
                  new SelectListItem{Text = "RUMAH IPAR", Value = "6"},
                  new SelectListItem{Text = "RUMAH PAMAN/TANTE", Value = "7"},
                    new SelectListItem{Text = "RUMAH SAUDARA KANDUNG", Value = "8"}
            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetHubunganKeluarga()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "SUAMI", Value = "1"},
                new SelectListItem{Text = "ISTRI", Value = "2"},
                new SelectListItem{Text = "SAUDARA KANDUNG", Value = "3"},
                  new SelectListItem{Text = "SAUDARA TIRI", Value = "4"},
                    new SelectListItem{Text = "ORANG TUA", Value = "5"},
                  new SelectListItem{Text = "MERTUA", Value = "6"},
                  new SelectListItem{Text = "PAMAN/TANTE", Value = "7"},
                    new SelectListItem{Text = "KAKEK NENEK", Value = "8"}
                    
            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetKarakter()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "BAIK", Value = "1"},
                new SelectListItem{Text = "CUKUP", Value = "2"},
                new SelectListItem{Text = "KURANG", Value = "3"},
                  new SelectListItem{Text = "JELEK", Value = "4"}
                   
            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetKerjasama()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "KOOPERATIF", Value = "1"},
                new SelectListItem{Text = "CUKUP", Value = "2"},
                new SelectListItem{Text = "KURANG", Value = "3"},
                  new SelectListItem{Text = "TIDAK KOOPERATIF", Value = "4"}

            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetJumlahTanggungan()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "1", Value = "1"},
                new SelectListItem{Text = "2", Value = "2"},
                new SelectListItem{Text = "3", Value = "3"},
                  new SelectListItem{Text = "4", Value = "4"},
                   new SelectListItem{Text = "5", Value = "5"},
                new SelectListItem{Text = "6", Value = "6"},
                new SelectListItem{Text = "7", Value = "7"},
                  new SelectListItem{Text = "8", Value = "8"},
                   new SelectListItem{Text = "9", Value = "9"},
                new SelectListItem{Text = "10", Value = "10"}
         
            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetSegmenRumah()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "MEWAH", Value = "1"},
                new SelectListItem{Text = "MENENGAH", Value = "2"},
                new SelectListItem{Text = "SEDERHANA", Value = "3"},
                  new SelectListItem{Text = "KUMUH", Value = "4"}

            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetKondisiJalanRumah()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "ASPAL", Value = "1"},
                new SelectListItem{Text = "CONEBLOCK / SIRTU", Value = "2"},
                new SelectListItem{Text = "SEMEN", Value = "3"},
                  new SelectListItem{Text = "TANAH", Value = "4"}

            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetKondisiPagar()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "BESI / TEMBOK", Value = "1"},
                new SelectListItem{Text = "KAYU / KAWAT", Value = "2"},
                new SelectListItem{Text = "TANAMAN", Value = "3"},
                  new SelectListItem{Text = "TIDAK ADA", Value = "4"}

            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetKondisiTanaman()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "TERAWAT", Value = "1"},
                new SelectListItem{Text = "TIDAK TERAWAT", Value = "2"},
                new SelectListItem{Text = "TIDAK ADA", Value = "3"}
                

            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetGarasiRumah()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "TERTUTUP", Value = "1"},
                new SelectListItem{Text = "BERATAP", Value = "2"},
                new SelectListItem{Text = "TERBUKA", Value = "3"},
                  new SelectListItem{Text = "TIDAK ADA", Value = "4"}

            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetDindingRumah()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "TEMBOK PLESTERAN", Value = "1"},
                new SelectListItem{Text = "TEMBOK NON PLESTERAN", Value = "2"},
                new SelectListItem{Text = "PAPAN", Value = "3"},
                  new SelectListItem{Text = "KOMBINASI", Value = "4"}

            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetAtapRumah()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "GENTENG BETON", Value = "1"},
                new SelectListItem{Text = "GENTENG TANAH LIAT", Value = "2"},
                new SelectListItem{Text = "SIRAP", Value = "3"},
                  new SelectListItem{Text = "ASBES", Value = "4"},
                    new SelectListItem{Text = "SENG", Value = "5"}

            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetLantaiRumah()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "GRANIT", Value = "1"},
                new SelectListItem{Text = "KERAMIK", Value = "2"},
                new SelectListItem{Text = "PLESTERAN", Value = "3"},
                  new SelectListItem{Text = "TEGEL", Value = "4"},
                    new SelectListItem{Text = "TANAH", Value = "5"}

            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetToilet()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "YA", Value = "1"},
                new SelectListItem{Text = "TIDAK ADA", Value = "2"}
          

            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetKondisiFisikRumah()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "TERAWAT", Value = "1"},
                new SelectListItem{Text = "TIDAK TERAWAT", Value = "2"}


            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetTv()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "YA", Value = "1"},
                new SelectListItem{Text = "TIDAK ADA", Value = "2"}


            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetKulkas()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "YA", Value = "1"},
                new SelectListItem{Text = "TIDAK ADA", Value = "2"}


            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetTempatSurvei()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "RUMAH", Value = "1"},
                new SelectListItem{Text = "KANTOR / TEMPAT USAHA", Value = "2"},
                   new SelectListItem{Text = "LAIN LAIN", Value = "3"}


            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetLokasiTempatTinggal()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "REAL ESTATE", Value = "1"},
                new SelectListItem{Text = "APARTEMEN", Value = "2"},
                new SelectListItem{Text = "KOMPLEKS PERUSAHAAN", Value = "3"},
                  new SelectListItem{Text = "CLUSTER", Value = "4"},
                   new SelectListItem{Text = "RUKO", Value = "5"},
                new SelectListItem{Text = "BTN", Value = "6"},
                new SelectListItem{Text = "KAMPUNG DESA", Value = "7"},
                  new SelectListItem{Text = "KOMPLEKS INSTANSI TNI/POLRI", Value = "8"},
                   new SelectListItem{Text = "KOMPLEKS INTANSI BUMN", Value = "9"}
          

            };
            return items;
        }
        public static IEnumerable<SelectListItem> GetHasilSurvei()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "ACC", Value = "1"},
                new SelectListItem{Text = "TOLAK", Value = "2"}
     


            };
            return items;
        }
      





    }
}
