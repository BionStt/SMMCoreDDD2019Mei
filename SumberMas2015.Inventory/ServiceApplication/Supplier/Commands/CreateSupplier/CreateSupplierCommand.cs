using MediatR;
using SumberMas2015.Inventory.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.Supplier.Commands.CreateSupplier
{
    public class CreateSupplierCommand:IRequest<Guid>
    {
        public string NamaSupplier { get; set; }
        public string Email { get; set; }
        public Alamat AlamatSupplier { get; set; }
        public Guid UserNameId { get; set; }
    }
}
