using SumberMas2015.Inventory.Dto;
using SumberMas2015.Inventory.Dto.Pembelian;
using SumberMas2015.Inventory.ServiceApplication.Pembelian.Commands.CreatePembelian;
using SumberMas2015.Inventory.ServiceApplication.Supplier.Commands.CreateSupplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.DtoMapping
{
    public static class InventoryRequestMapping
    {
        public static CreatePembelianCommand ToCommand(this CreatePembelianRequest model )
        {
            return new CreatePembelianCommand {
                DataSupplierId = model.DataSupplierId,
                JenisTransaksiPembelian = model.JenisTransaksiPembelian,
                Keterangan = model.Keterangan,
                PurchaseOrderId =model.PurchaseOrderId,
                Tenor = model.Tenor,
                UserNameInput = model.UserNameInput

            };
        }
        public static CreateSupplierCommand ToCommand(this CreateSupplierRequest model)
        {
            return new CreateSupplierCommand {
                Email = model.Email,
                NamaSupplier = model.NamaSupplier,
                AlamatSupplier = Domain.ValueObjects.Alamat.CreateAlamat(model.Jalan,model.Kelurahan,model.Kecamatan,model.Kota,model.Propinsi,
                model.KodePos,model.NomorTelepon,model.NomorFaks,model.NomorHandphone)

            };
        }





    }
}
