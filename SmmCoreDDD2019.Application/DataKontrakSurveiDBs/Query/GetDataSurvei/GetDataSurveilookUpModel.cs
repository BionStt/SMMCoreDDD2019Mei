using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.DataKontrakSurveiDBs.Query.GetDataSurvei
{
    public class GetDataSurveilookUpModel : IHaveCustomMapping
    {
        public int NoDataSurveiAvalist { get; set; }
        public string NamaKonsumen { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<DataKontrakSurvei, GetDataSurveilookUpModel>()
             .ForMember(cDTO => cDTO.NoDataSurveiAvalist, opt => opt.MapFrom(c => c.NoUrutDataSurvei));
            //.ForMember(cDTO => cDTO.NamaKonsumen, opt => opt.MapFrom(c => c.nama));
            //  .ForMember(cDTO => cDTO.NamaPembelian, opt => opt.MapFrom(c => string.Format("{0} - {1:d} - {2}", c.KodeBeli, c.TglBeli, c.Idsupplier)));


        }
    }
}
