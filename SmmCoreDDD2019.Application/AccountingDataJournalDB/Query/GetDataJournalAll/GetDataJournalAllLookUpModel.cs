using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetDataJournalAll
{
    public class GetDataJournalAllLookUpModel : IHaveCustomMapping
    {
        public int AccountingDataAccountId { get; set; }
        public int AccountingDataJournalIdH { get; set; }
        public string DataAkun { get; set; }
        public decimal Debit1 { get; set; }
        public decimal Kredit1 { get; set; }
        public string Ket1 { get; set; }
        public DateTime TanggalInput { get; set; }
        public string NoBuktiJurnal { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<AccountingDataJournal, GetDataJournalAllLookUpModel>()
               .ForMember(cDTO => cDTO.AccountingDataAccountId, opt => opt.MapFrom(c => c.Id));
            // .ForMember(cDTO => cDTO.KodeAccount, opt => opt.MapFrom(c => c.KodeAccount))
            //   .ForMember(cDTO => cDTO.Account, opt => opt.MapFrom(c => c.Account))
            //     .ForMember(cDTO => cDTO.NormalPos, opt => opt.MapFrom(c => c.NormalPos))
            //           .ForMember(cDTO => cDTO.Depth, opt => opt.MapFrom(c => c.Depth))
            //.ForMember(cDTO => cDTO.Kelompok, opt => opt.MapFrom(c => c.Kelompok));
            // throw new NotImplementedException();
        }
    }
}
