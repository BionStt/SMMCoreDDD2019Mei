using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumberMas2015.Inventory.InfrastructureData.Context;

namespace SumberMas2015.Inventory.InfrastructureData
{
    public class DbInitializer
    {
        public static async Task Initialize(InventoryContext context)
        {
            var initializer = new DbInitializer();
            await initializer.SeedEverything(context);
        }
        public async Task SeedEverything(InventoryContext context)
        {
            context.Database.EnsureCreated();

            await SeedMasterSupplier(context);
            await SeedMasterBarang(context);

        }

        private async Task SeedMasterBarang(InventoryContext context)
        {
            if (context.MasterBarang.Any())
            {
                return;
            }
            var masterBarang = new[]
            {
                Domain.MasterBarang.Create("BEAT STREET CBS ACC","MH1","","HONDA","110",decimal.Parse("13781000"),decimal.Parse("2875000"),"2019","D1I2N2A2A/T"),

            };
            context.MasterBarang.AddRange(masterBarang);
            // context.MasterBarang.Add(masterBarang);
            await context.SaveChangesAsync();
        }

        private async Task SeedMasterSupplier(InventoryContext context)
        {
            if (context.Supplier.Any())
            {
                return;
            }
            var mstSupplier = new[]
            {
                 Domain.Supplier.CreateSupplier(Domain.ValueObjects.Alamat.CreateAlamat("JL TELUK GONG RAYA NO,187","PEJAGALAN","PENJARINGAN","JAKARTA UTARA","DKI JAKARTA","14450","0216697631","0216697631","08111806368"),
                 "PT SUMATERA MOTOR","sumatera@gmail.com"),

            };
                context.Supplier.AddRange(mstSupplier);
            await context.SaveChangesAsync();

        }





    }
}
