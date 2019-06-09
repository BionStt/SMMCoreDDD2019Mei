using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerDBDetail
{
   public  class CustomerDetailModel
    {
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
        public string Nama { get; set; }
        public string NamaBPKB { get; set; }
        public string NoKtp { get; set; }
        public string Pekerjaan { get; set; }
        public string Telp { get; set; }
        public string TelpKantor { get; set; }
        public DateTime? TglInput { get; set; }
        public DateTime TglLahir { get; set; }
        public int? UserIDPeg { get; set; }
        public string UserInput { get; set; }

        public static Expression<Func<CustomerDB, CustomerDetailModel>> Projection
        {
            get
            {
                return customer => new CustomerDetailModel
                {
                    CustomerID = customer.CustomerID,
                    Alamat = customer.Alamat,
                    AlamatKirim = customer.AlamatKirim,
                    Faks = customer.Faks,
                    Handphone = customer.Handphone,
                    Kecamatan= customer.Kecamatan,
                    Kelurahan = customer.Kelurahan,
                    KodePos= customer.KodePos,
                    Kota = customer.Kota,
                    Nama= customer.Nama,
                    NamaBPKB= customer.NamaBPKB,
                    NoKtp = customer.NoKtp,
               
                    Telp= customer.Telp,
                    TelpKantor= customer.TelpKantor,
                    TglLahir = customer.TglLahir,
                    UserIDPeg = customer.UserIDPeg,
                    UserInput = customer.UserInput
                };
            }
        }

        public static CustomerDetailModel Create(CustomerDB customer)
        {
            return Projection.Compile().Invoke(customer);
        }

    }
}
