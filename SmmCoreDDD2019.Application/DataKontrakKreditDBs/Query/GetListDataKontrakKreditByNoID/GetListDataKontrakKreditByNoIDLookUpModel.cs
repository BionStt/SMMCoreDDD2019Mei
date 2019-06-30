using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.DataKontrakKreditDBs.Query.GetListDataKontrakKreditByNoID
{
    public class GetListDataKontrakKreditByNoIDLookUpModel : IHaveCustomMapping
    {
        public int NoUrutDataKontrakKredit1 { get; set; }
        public string NamaKonsumen1 { get; set; }
       public string NamaPenjamin1 { get; set; }
        public string AlamatRumah { get; set; }
        public string NoTeleponRumah { get; set; }
        public string NoTeleponKantor { get; set; }
        public string NoTeleponUsaha { get; set; }
        public string NoHP1 { get; set; }
        public string NoHP2 { get; set; }
        public double NilaiKontrak1 { get; set; }
        public double NilaiBunga1 { get; set; }
        public string Tenor1 { get; set; }
        public double Angsuran1 { get; set; }
        public double pinjamanPokok { get; set; }




        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<DataKontrakKredit, GetListDataKontrakKreditByNoIDLookUpModel>()
             .ForMember(cDTO => cDTO.NoUrutDataKontrakKredit1, opt => opt.MapFrom(c => c.Id));
            //  .ForMember(cDTO => cDTO.NamaPemesan, opt => opt.MapFrom(c => c.NamaPemesan));

        }
    }
}
