using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.AccountingTipeJournalDB.Query.GetTipeJournal
{
    public class GetTipeJournalLookUpModel : IHaveCustomMapping
    {
        public int NoIDTipeJournal { get; set; }
        public string KodeJournal { get; set; }
        public string NamaJournal { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<AccountingTipeJournal, GetTipeJournalLookUpModel>()
               .ForMember(cDTO => cDTO.NoIDTipeJournal, opt => opt.MapFrom(c => c.Id))
             .ForMember(cDTO => cDTO.KodeJournal, opt => opt.MapFrom(c => c.KodeJournal))
             .ForMember(cDTO => cDTO.NamaJournal, opt => opt.MapFrom(c => c.NamaJournal));

            // .ForMember(cDTO => cDTO.KodeAccount, opt => opt.MapFrom(c => c.KodeAccount))
            //   .ForMember(cDTO => cDTO.Account, opt => opt.MapFrom(c => c.Account))
            //     .ForMember(cDTO => cDTO.NormalPos, opt => opt.MapFrom(c => c.NormalPos))
            //           .ForMember(cDTO => cDTO.Depth, opt => opt.MapFrom(c => c.Depth))
            //.ForMember(cDTO => cDTO.Kelompok, opt => opt.MapFrom(c => c.Kelompok));
            // throw new NotImplementedException();
        }
    }
}
