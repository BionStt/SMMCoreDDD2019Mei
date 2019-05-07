using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Application.DataPegawaiFotos.Queries.GetDataPegawaiList
{
    public class DataPegawaiLookUpModel : IHaveCustomMapping
    {
        public string IdPegawai { get; set; }
   //     public string Name { get; set; }
        public byte[] Foto { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<DataPegawaiFoto, DataPegawaiLookUpModel>()
                .ForMember(cDTO => cDTO.IdPegawai, opt => opt.MapFrom(c => c.IDPegawai))
                .ForMember(cDTO => cDTO.Foto, opt => opt.MapFrom(c => c.Foto));
        }
    }
}
