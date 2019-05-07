using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.MasterBidangUsahaDBs.Query.GetNamaBidangUsaha
{
    public class GetNamaBidangUsahaLookUpModel : IHaveCustomMapping
    {
        public int NoKodeMasterBidangUsaha { get; set; }
        public string NamaMasterBidangUsaha { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<MasterBidangUsahaDB, GetNamaBidangUsahaLookUpModel>()
               .ForMember(cDTO => cDTO.NoKodeMasterBidangUsaha, opt => opt.MapFrom(c => c.NoKodeMasterBidangUsaha))
               .ForMember(cDTO => cDTO.NamaMasterBidangUsaha, opt => opt.MapFrom(c => c.NamaMasterBidangUsaha));

            // throw new NotImplementedException();
        }
    }
}
