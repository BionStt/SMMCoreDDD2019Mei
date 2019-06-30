using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.StokUnits.Query.GetDataSO
{
    public class GetDataSOLookUpModel : IHaveCustomMapping
    {
    
          public int NoUrutSO { get; set; }
        public string NamaBarang{ get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<StokUnit, GetDataSOLookUpModel>()
             .ForMember(cDTO => cDTO.NoUrutSO, opt => opt.MapFrom(c => c.Id));
            // .ForMember(cDTO => cDTO.NamaBarang, opt => opt.MapFrom(c => c.NamaBarang));
           // .ForMember(cDTO => cDTO.NamaBarang, opt => opt.MapFrom(c => string.Format("{0} - {1:d} - {2}", c.KodeBeli, c.TglBeli, c.Idsupplier)));


        }
    }
}
