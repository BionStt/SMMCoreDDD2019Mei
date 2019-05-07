using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetLaporanNeraca
{
    public class GetLaporanNeracaLookUpModel : IHaveCustomMapping
    {
        public string nm { get; set; }
        public string KodeAccountParent { get; set; }
        public string AccountParent { get; set; }
        public string KodeAccountParent1 { get; set; }
        public string AccountParent1 { get; set; }
        public string KodeAccount1 { get; set; }
        public string Account1a { get; set; }
        public decimal Debit1 { get; set; }
        public decimal Kredit1 { get; set; }
        public decimal? Saldo1 { get; set; }
        public int? depth1 { get; set; }
        public string KodeAkunInduk { get; set; }
        public int? normalPosInduk { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<AccountingDataJournal, GetLaporanNeracaLookUpModel>()
               .ForMember(cDTO => cDTO.Debit1, opt => opt.MapFrom(c => c.Debit));
            // .ForMember(cDTO => cDTO.KodeAccount, opt => opt.MapFrom(c => c.KodeAccount))
            //   .ForMember(cDTO => cDTO.Account, opt => opt.MapFrom(c => c.Account))
            //     .ForMember(cDTO => cDTO.NormalPos, opt => opt.MapFrom(c => c.NormalPos))
            //           .ForMember(cDTO => cDTO.Depth, opt => opt.MapFrom(c => c.Depth))
            //.ForMember(cDTO => cDTO.Kelompok, opt => opt.MapFrom(c => c.Kelompok));
            // throw new NotImplementedException();
        }
    }
}
