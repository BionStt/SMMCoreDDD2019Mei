using Microsoft.EntityFrameworkCore;
using SumberMas2015.Organization.Domain;
using SumberMas2015.Organization.Domain.EnumInEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.InfrastructureData.Context
{
    public class OrganizationContext : DbContext
    {
        public OrganizationContext(DbContextOptions<OrganizationContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // please. you want input one by one or assembly

            //  builder.ApplyConfiguration(new DataKonsumenConfiguration());
            builder.ApplyConfigurationsFromAssembly(typeof(OrganizationContext).Assembly);//test pakai ini
        }
        public DbSet<JenisKompetensi> JenisKompetensi{ get; set; }
        public DbSet<TrainingCourses> TrainingCourses { get; set; }
        public DbSet<DataPerusahaan> DataPerusahaan { get; set; }
        public DbSet<DataPerusahaanCabang> DataPerusahaanCabang { get; set; }

        public DbSet<DataKamusKompetensi> DataKamusKompetensi { get; set; }

        public DbSet<DataKamusKompetensiIndikatorPerilaku> DataKamusKompetensiIndikatorPerilaku { get; set; }
        public DbSet<DataKamusKompetensiLeveling> DataKamusKompetensiLeveling { get; set; }
        public DbSet<DataPerusahaanJobDescription> DataPerusahaanJobDescription { get; set; }
        public DbSet<DataPerusahaanJobSpecification> DataPerusahaanJobSpecification { get; set; }
        public DbSet<DataPerusahaanMisi> DataPerusahaanMisi { get; set; }
        public DbSet<DataPerusahaanVisi> DataPerusahaanVisi { get; set; }
        public DbSet<DataPerusahaanOrganisasiChart> DataPerusahaanOrganisasiChart { get; set; }
        public DbSet<DataPerusahaanProsesBisnis> DataPerusahaanProsesBisnis { get; set; }
        public DbSet<DataPerusahaanSalaryStructure> DataPerusahaanSalaryStructure { get; set; }
        public DbSet<DataPerusahaanValue> DataPerusahaanValue { get; set; }
    



    }
}
