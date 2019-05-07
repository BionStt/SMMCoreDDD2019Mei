using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.AccountingDataAccountDB.Query.GetDataAccountByDepth
{
    public class GetDataAccountByDepthLookUpModel : IHaveCustomMapping
    {
        public int NoUrutAccountId { get; set; }
        public string KodeAccount { get; set; }
        public string Account { get; set; }
        public string DataAkun1 { get; set; }
        public string DataAkun2 { get; set; }
      
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<AccountingDataAccount, GetDataAccountByDepthLookUpModel>()
               .ForMember(cDTO => cDTO.NoUrutAccountId, opt => opt.MapFrom(c => c.NoUrutAccountId))
               .ForMember(cDTO => cDTO.KodeAccount, opt => opt.MapFrom(c => c.KodeAccount))
                 .ForMember(cDTO => cDTO.Account, opt => opt.MapFrom(c => c.Account));
            
                    
          
           
        }
    }
}
