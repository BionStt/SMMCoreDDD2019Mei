using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.AccountingDataAccountDB.Query.GetAllDataAccountOrderByKodeAccount
{
    public class GetAllDataAccountOrderByKodeAccountLookUpModel : IHaveCustomMapping
    {
        public int NoUrutAccountId { get; set; }
        public string KodeAccount { get; set; }
        public string Account { get; set; }
        public string NormalPos { get; set; }
        public string Kelompok { get; set; }
        public int Depth { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<AccountingDataAccount, GetAllDataAccountOrderByKodeAccountLookUpModel>()
               .ForMember(cDTO => cDTO.NoUrutAccountId, opt => opt.MapFrom(c => c.NoUrutAccountId))
               .ForMember(cDTO => cDTO.KodeAccount, opt => opt.MapFrom(c => c.KodeAccount))
                 .ForMember(cDTO => cDTO.Account, opt => opt.MapFrom(c => c.Account))
                   .ForMember(cDTO => cDTO.NormalPos, opt => opt.MapFrom(c => c.NormalPos))
                         .ForMember(cDTO => cDTO.Depth, opt => opt.MapFrom(c => c.Depth))
              .ForMember(cDTO => cDTO.Kelompok, opt => opt.MapFrom(c => c.Kelompok));
            // throw new NotImplementedException();
        }
    }
}
