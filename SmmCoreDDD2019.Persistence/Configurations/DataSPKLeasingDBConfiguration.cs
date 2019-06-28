using System;
using System.Collections.Generic;
using System.Text;


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataSPKLeasingDBConfiguration : IEntityTypeConfiguration<DataSPKLeasingDB>
    {
        public void Configure(EntityTypeBuilder<DataSPKLeasingDB> builder)
        {
            builder.ToTable("DataSPKLeasingDB", "DataSPKBaruDB");
            builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("DataSPKLeasingDB_hilo").IsRequired();
       
         
            builder.Property(e=>e.NoUrutSales);

            builder.Property(e => e.Angsuran).HasColumnType("money");

            builder.Property(e => e.MasterLeasingCabangDBId);

            builder.Property(e => e.Mediator).HasMaxLength(100).IsUnicode(false);

            builder.Property(e => e.NamaCmo).HasColumnName("NamaCMO").HasMaxLength(100).IsUnicode(false);

            builder.Property(e => e.MasterKategoriPenjualanId);

            builder.Property(e => e.DataSPKBaruDBId);

            builder.Property(e => e.Tenor).HasColumnName("tenor");

            builder.Property(e => e.TglSurvei).HasColumnType("datetime");
           
        }
    }
}
