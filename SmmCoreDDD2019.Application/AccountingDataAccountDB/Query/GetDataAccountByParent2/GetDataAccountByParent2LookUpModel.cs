using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.AccountingDataAccountDB.Query.GetDataAccountByParent2
{
    public class GetDataAccountByParent2LookUpModel : IHaveCustomMapping
    {
        public int NoUrutAccountId { get; set; }
        public string DataAkun { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<AccountingDataAccount, GetDataAccountByParent2LookUpModel>()
               .ForMember(cDTO => cDTO.NoUrutAccountId, opt => opt.MapFrom(c => c.NoUrutAccountId));
            // .ForMember(cDTO => cDTO.KodeAccount, opt => opt.MapFrom(c => c.KodeAccount))
            //   .ForMember(cDTO => cDTO.Account, opt => opt.MapFrom(c => c.Account))
            //     .ForMember(cDTO => cDTO.NormalPos, opt => opt.MapFrom(c => c.NormalPos))
            //           .ForMember(cDTO => cDTO.Depth, opt => opt.MapFrom(c => c.Depth))
            //.ForMember(cDTO => cDTO.Kelompok, opt => opt.MapFrom(c => c.Kelompok));
            // throw new NotImplementedException();
        }
    }
}
