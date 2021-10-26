using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.Domain
{
    public class Supplier
    {
        public int NoUrutId { get; private set; }
        public Guid SupplierId { get; private set; }

        public Alamat AlamatSupplier { get; set; }
        public string NamaSupplier { get; private set; }
        public string Email { get; private set; }

        protected Supplier()
        {

        }

        private Supplier(Alamat alamatSupplier, string namaSupplier, string email)
        {
            SupplierId = Guid.NewGuid();
            AlamatSupplier = alamatSupplier;
            NamaSupplier = namaSupplier;
            Email = email;
        }
        public static Supplier CreateSupplier(Alamat alamatSupplier, string namaSupplier, string email)
        {
            return new Supplier(alamatSupplier, namaSupplier, email);
        }
    }
}
