using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetDataJournalByKodeAkun
{
    public class GetDataJournalByKodeAkunLookUpModel : IHaveCustomMapping
    {
        public int NoUrutAccountId { get; set; }
        public int NoUrutJournalHeaderId { get; set; }
        public string DataAkun { get; set; }
        public decimal Debit1 { get; set; }
        public decimal Kredit1 { get; set; }
        public string Ket1 { get; set; }
        public DateTime TanggalInput { get; set; }
        public string NoBuktiJurnal { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<AccountingDataJournal, GetDataJournalByKodeAkunLookUpModel>()
               .ForMember(cDTO => cDTO.NoUrutAccountId, opt => opt.MapFrom(c => c.Id));
            // .ForMember(cDTO => cDTO.KodeAccount, opt => opt.MapFrom(c => c.KodeAccount))
            //   .ForMember(cDTO => cDTO.Account, opt => opt.MapFrom(c => c.Account))
            //     .ForMember(cDTO => cDTO.NormalPos, opt => opt.MapFrom(c => c.NormalPos))
            //           .ForMember(cDTO => cDTO.Depth, opt => opt.MapFrom(c => c.Depth))
            //.ForMember(cDTO => cDTO.Kelompok, opt => opt.MapFrom(c => c.Kelompok));
            // throw new NotImplementedException();
        }
    }
}
