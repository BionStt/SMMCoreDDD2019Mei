using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.DataPegawaiDataPribadiInput.Queries.GetNamaSalesForce
{
    public class GetNamaSalesForceLookUpModel : IHaveCustomMapping
    {
        public int IDPegawai { get; set; }
        public string NamaDepan { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<DataPegawaiDataPribadi, GetNamaSalesForceLookUpModel>()
             .ForMember(cDTO => cDTO.IDPegawai, opt => opt.MapFrom(c => c.IDPegawai))
             .ForMember(cDTO => cDTO.NamaDepan, opt => opt.MapFrom(c => c.NamaDepan));

        }
    }
}
