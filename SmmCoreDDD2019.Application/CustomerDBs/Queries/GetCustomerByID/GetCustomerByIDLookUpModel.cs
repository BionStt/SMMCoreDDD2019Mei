using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerByID
{
    public class GetCustomerByIDLookUpModel : IHaveCustomMapping
    {
        //  public int NoUrutKendaraan { get; set; }
        public string NoKodeCustomer { get; set; }
        public int CustomerID { get; set; }
        public string Alamat { get; set; }
        public string AlamatKirim { get; set; }
        public string Faks { get; set; }
        public string Handphone { get; set; }
        public string Jual { get; set; }
        public string Kecamatan { get; set; }
        public string Kelurahan { get; set; }
        public string KodePos { get; set; }
        public string Kota { get; set; }
        public string Propinsi { get; set; }
        public string Nama { get; set; }
        public string NamaBPKB { get; set; }
        public string NoKtp { get; set; }
        public string Email { get; set; }
        public string Telp { get; set; }
        public string TelpKantor { get; set; }
        public DateTime? TglInput { get; set; }
        public DateTime TglLahir { get; set; }
        public int? UserIDPeg { get; set; }
        public string UserInput { get; set; }
        public string KodeBidangPekerjaan { get; set; }
        public string NamaBidangPekerjaan { get; set; }
        public string KodeBidangUsaha { get; set; }
        public string NamaBidangUsaha { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<CustomerDB, GetCustomerByIDLookUpModel>()
             .ForMember(cDTO => cDTO.NoKodeCustomer, opt => opt.MapFrom(c => c.NoKodeCustomer))
           .ForMember(cDTO => cDTO.CustomerID, opt => opt.MapFrom(c => c.CustomerID))
             .ForMember(cDTO => cDTO.Alamat, opt => opt.MapFrom(c => c.Alamat))
               .ForMember(cDTO => cDTO.Faks, opt => opt.MapFrom(c => c.Faks))
                 .ForMember(cDTO => cDTO.Handphone, opt => opt.MapFrom(c => c.Handphone))
                   .ForMember(cDTO => cDTO.Jual, opt => opt.MapFrom(c => c.Jual))
                     .ForMember(cDTO => cDTO.Kecamatan, opt => opt.MapFrom(c => c.Kecamatan))
                       .ForMember(cDTO => cDTO.Kelurahan, opt => opt.MapFrom(c => c.Kelurahan))
                         .ForMember(cDTO => cDTO.KodePos, opt => opt.MapFrom(c => c.KodePos))
                           .ForMember(cDTO => cDTO.Kota, opt => opt.MapFrom(c => c.Kota))
                             .ForMember(cDTO => cDTO.Propinsi, opt => opt.MapFrom(c => c.Propinsi))
                               .ForMember(cDTO => cDTO.Nama, opt => opt.MapFrom(c => c.Nama))
                                 .ForMember(cDTO => cDTO.NamaBPKB, opt => opt.MapFrom(c => c.NamaBPKB))
                                   .ForMember(cDTO => cDTO.NoKtp, opt => opt.MapFrom(c => c.NoKtp))
                                     .ForMember(cDTO => cDTO.Email, opt => opt.MapFrom(c => c.Email))
                                          .ForMember(cDTO => cDTO.Telp, opt => opt.MapFrom(c => c.Telp))
                                 .ForMember(cDTO => cDTO.TelpKantor, opt => opt.MapFrom(c => c.TelpKantor))
                                   .ForMember(cDTO => cDTO.TglInput, opt => opt.MapFrom(c => c.TglInput))
                                     .ForMember(cDTO => cDTO.TglLahir, opt => opt.MapFrom(c => c.TglLahir))
                                          .ForMember(cDTO => cDTO.UserIDPeg, opt => opt.MapFrom(c => c.UserIDPeg))
                                 .ForMember(cDTO => cDTO.UserInput, opt => opt.MapFrom(c => c.UserInput))
                                   .ForMember(cDTO => cDTO.KodeBidangPekerjaan, opt => opt.MapFrom(c => c.KodeBidangPekerjaan))
                                     .ForMember(cDTO => cDTO.NamaBidangPekerjaan, opt => opt.MapFrom(c => c.NamaBidangPekerjaan))
                                      .ForMember(cDTO => cDTO.KodeBidangUsaha, opt => opt.MapFrom(c => c.KodeBidangUsaha))
                                       .ForMember(cDTO => cDTO.NamaBidangUsaha, opt => opt.MapFrom(c => c.NamaBidangUsaha));
                    // .ForMember(cDTO => cDTO.NamaBarang, opt => opt.MapFrom(c => string.Format("{0} - {1} - {2:c}", c.NamaBarang, c.Merek, (c.Harga + c.BBN))));


        }
    }
}
