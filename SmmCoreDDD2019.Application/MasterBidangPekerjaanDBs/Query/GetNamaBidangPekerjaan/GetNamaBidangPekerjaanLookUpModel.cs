using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.MasterBidangPekerjaanDBs.Query.GetNamaBidangPekerjaan
{
    public class GetNamaBidangPekerjaanLookUpModel : IHaveCustomMapping
    {
        public int NoUrutBidangPekerjaan { get; set; }
        public string NamaMasterBidangPekerjaan { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<MasterBidangPekerjaanDB, GetNamaBidangPekerjaanLookUpModel>()
               .ForMember(cDTO => cDTO.NoUrutBidangPekerjaan, opt => opt.MapFrom(c => c.Id))
               .ForMember(cDTO => cDTO.NamaMasterBidangPekerjaan, opt => opt.MapFrom(c => c.NamaMasterBidangPekerjaan));

            // throw new NotImplementedException();
        }
    }
}
