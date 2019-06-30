using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.DataKontrakKreditDBs.Query.GetListDataKontrakKredit
{
    public class GetListDataKontrakKreditLookUpModel : IHaveCustomMapping
    {
        public int NoUrutDataKontrakKredit1 { get; set; }
        public string DataKontrakKredit { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<DataKontrakKredit, GetListDataKontrakKreditLookUpModel>()
             .ForMember(cDTO => cDTO.NoUrutDataKontrakKredit1, opt => opt.MapFrom(c => c.Id));
            //  .ForMember(cDTO => cDTO.NamaPemesan, opt => opt.MapFrom(c => c.NamaPemesan));

        }
    }
}
