using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.MasterBarangDBs.Queries.GetNamaBarangQrByNoUrut
{
    public class GetNamaBarangQrByNoUrutLookUpModel : IHaveCustomMapping
    {
        //  public int NoUrutKendaraan { get; set; }
        public decimal HargaOff { get; set; }
        public decimal BBN1 { get; set; }


        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<MasterBarangDB, GetNamaBarangQrByNoUrutLookUpModel>()
               //  .ForMember(cDTO => cDTO.NoUrutKendaraan, opt => opt.MapFrom(c => c.NoUrutTypeKendaraan))
               .ForMember(cDTO => cDTO.HargaOff, opt => opt.MapFrom(c => c.Harga))
             .ForMember(cDTO => cDTO.BBN1, opt => opt.MapFrom(c => c.BBN));


            // throw new NotImplementedException();
        }
    }
}
