using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.MasterKategoriBayaranDbs.Query.GetNamaKategoryBayaran
{
    public class GetNamaKategoryBayaranlookUpModel : IHaveCustomMapping
    {
        public int NoUrut { get; set; }
        public string NamaKategoryBayaran { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<MasterKategoriBayaran, GetNamaKategoryBayaranlookUpModel>()
             .ForMember(cDTO => cDTO.NoUrut, opt => opt.MapFrom(c => c.Id))
             .ForMember(cDTO => cDTO.NamaKategoryBayaran, opt => opt.MapFrom(c => c.NamaKategoryBayaran));

        }
    }
}
