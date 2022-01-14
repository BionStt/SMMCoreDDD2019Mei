using SumberMas2015.Inventory.Dto;
using SumberMas2015.Inventory.Dto.MasterBarang;
using SumberMas2015.Inventory.Dto.Pembelian;
using SumberMas2015.Inventory.Dto.PembelianDetail;
using SumberMas2015.Inventory.Dto.PurchaseOrderPembelian;
using SumberMas2015.Inventory.Dto.PurchaseOrderPembelianDetail;
using SumberMas2015.Inventory.Dto.StokUnit;
using SumberMas2015.Inventory.ServiceApplication.MasterBarang.Commands.CreateMasterBarang;
using SumberMas2015.Inventory.ServiceApplication.Pembelian.Commands.CreatePembelian;
using SumberMas2015.Inventory.ServiceApplication.PembelianDetail.Commands.CreatePembelianDetail;
using SumberMas2015.Inventory.ServiceApplication.PurchaseOrderPembelian.Commands.CreatePurchaseOrderPembelian;
using SumberMas2015.Inventory.ServiceApplication.PurchaseOrderPembelianDetail.Commands.CreatePurchaseOrderPembelianDetail;
using SumberMas2015.Inventory.ServiceApplication.StokUnit.Commands.CreateStokUnit;
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
        public static CreatePembelianDetailCommand ToCommand(this CreatePembelianDetailRequest model)
        {
            return new CreatePembelianDetailCommand {
            BBN = model.BBN,
            Diskon = model.Diskon,
            Diskon2 = model.Diskon2,
            DiskonPPN = model.DiskonPPN,
            Harga1 = model.Harga1,
            HargaOffTheRoad = model.HargaOffTheRoad,
            HargaPPN = model.HargaPPN,
            Qty = model.Qty,
            SellIn = model.SellIn,
            Sellin2 = model.Sellin2,
            SellInPPN=model.SellInPPN


            };
        }
        public static CreateStokUnitCommand ToCommand(this CreateStokUnitRequest model)
        {
            return new CreateStokUnitCommand {
            Diskon = model.Diskon,
            Diskon2 = model.Diskon2,
            DiskonPPN = model.DiskonPPN,
            Harga = model.Harga,
            Harga1 = model.Harga1,
            HargaPPN = model.HargaPPN,
            masterBarangId = model.masterBarangId,
            NomorMesin = model.NomorMesin,
            NomorRangka = model.NomorRangka,
               pembelianDetailId = model.pembelianDetailId,
               Sellin = model.Sellin,
            SellIn2= model.SellIn2,
                SellInPPN = model.SellInPPN,
                Warna = model.Warna,
                NamaSupplier = model.NamaSupplier




            };
        }
        public static CreatePurchaseOrderPembelianDetailCommand ToCommand(this CreatePurchaseOrderPembelianDetailRequest model)
        {
            return new CreatePurchaseOrderPembelianDetailCommand {
            BBN = model.BBN,
            Diskon = model.Diskon,
            Keterangan = model.Keterangan,
            OffTHeRoad = model.OffTHeRoad,
            Qty  = model.Qty,
            Warna = model.Warna,
            UserName   = model.UserName,
            UserNameId = model.UserNameId,
            MasterBarangId = model.NoUrutMasterBarang,
            NoUrutPOPembelian = model.NoUrutPurchaseOrderID
            


            };
        }
        public static CreatePurchaseOrderPembelianCommand ToCommand(this CreatePurchaseOrderPembelianRequest model )
        {
            return new CreatePurchaseOrderPembelianCommand {
            Keterangan = model.Keterangan,
            MasterSupplierId = model.MasterSupplierId,
            PoASTRA  = model.PoASTRA,
            UserName= model.UserName,
            UserNameId = model.UserNameId

            };
        }
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
                UserNameId = model.UserNameInput,
                AlamatSupplier = Domain.ValueObjects.Alamat.CreateAlamat(model.Jalan,model.Kelurahan,model.Kecamatan,model.Kota,model.Propinsi,
                model.KodePos,model.NomorTelepon,model.NomorFaks,model.NomorHandphone)

            };
        }

        public static CreateMasterBarangCommand ToCommand(this CreateMasterBarangRequest model)
        {
            return new CreateMasterBarangCommand { 
            BBn = model.BBn,
            HargaOff = model.HargaOff,
            KapasitasMesin = model.KapasitasMesin,
            Merek = model.Merek,
            NamaBarang = model.NamaBarang,
            NomorMesin = model.NomorMesin,
            NomorRangka = model.NomorRangka,
            TahunPerakitan = model.TahunPerakitan,
            TypeKendaraan = model.TypeKendaraan,
            UserName= model.UserName,
            USerNameId = Guid.Parse(model.UserId)//eror gak nih
            
            };
        }



    }
}
