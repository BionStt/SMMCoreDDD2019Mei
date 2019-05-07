using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.StokUnits.Query.GetDataSOByID
{
    public class GetDataSOByIDLookUpModel : IHaveCustomMapping
    {
        //  public int NoUrutKendaraan { get; set; }
        public decimal HargaOff { get; set; }
        public decimal BBN { get; set; }
    

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<MasterBarangDB, GetDataSOByIDLookUpModel>()
               //  .ForMember(cDTO => cDTO.NoUrutKendaraan, opt => opt.MapFrom(c => c.NoUrutTypeKendaraan))
               .ForMember(cDTO => cDTO.HargaOff, opt => opt.MapFrom(c => c.Harga))
                
             .ForMember(cDTO => cDTO.BBN, opt => opt.MapFrom(c => c.BBN));


            // throw new NotImplementedException();
        }
    }
}
