using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.DataKontrakAngsuranDBs.Query.GetDataKontrakAngsuranByNoID
{
    public class GetDataKontrakAngsuranByNoIDLookUpModel : IHaveCustomMapping
    {
        public int NoUrutDataKontrakKredit1 { get; set; }
        public string AngsuranKeA { get; set; }
     
        public DateTime TanggalAngsuran1 { get; set; }
        public decimal AngsuranPerBulan { get; set; }
        public decimal Pokok1 { get; set; }
        public decimal Bunga1 { get; set; }
        public decimal SisaPokok1 { get; set; }
        public decimal SisaBunga1 { get; set; }


        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<DataKontrakAngsuran, GetDataKontrakAngsuranByNoIDLookUpModel>()
             .ForMember(cDTO => cDTO.NoUrutDataKontrakKredit1, opt => opt.MapFrom(c => c.DataKontrakKreditId));
            //  .ForMember(cDTO => cDTO.NamaPemesan, opt => opt.MapFrom(c => c.NamaPemesan));

        }
    }
}
