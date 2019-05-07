using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.MasterJenisJabatanDBs.Query.GetNamaJabatan
{
    public class GetNamaJabatanLookUpModel : IHaveCustomMapping
    {
        public int NoUrut { get; set; }
        public string NamaJabatan{ get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<MasterJenisJabatan, GetNamaJabatanLookUpModel>()
             .ForMember(cDTO => cDTO.NoUrut, opt => opt.MapFrom(c => c.NoUrut))
             .ForMember(cDTO => cDTO.NamaJabatan, opt => opt.MapFrom(c => c.NamaJabatan));

        }
    }
}
