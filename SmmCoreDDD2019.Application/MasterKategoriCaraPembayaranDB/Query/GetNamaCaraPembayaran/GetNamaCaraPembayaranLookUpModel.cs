using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.MasterKategoriCaraPembayaranDB.Query.GetNamaCaraPembayaran
{
    public class GetNamaCaraPembayaranLookUpModel : IHaveCustomMapping
    {
        public int NoUrut { get; set; }
        public string NamaKategoryCaraBayaran { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<MasterKategoriCaraPembayaran, GetNamaCaraPembayaranLookUpModel>()
             .ForMember(cDTO => cDTO.NoUrut, opt => opt.MapFrom(c => c.NoUrutCaraBayar))
             .ForMember(cDTO => cDTO.NamaKategoryCaraBayaran, opt => opt.MapFrom(c => c.CaraPembayaran));

        }
    }
}
