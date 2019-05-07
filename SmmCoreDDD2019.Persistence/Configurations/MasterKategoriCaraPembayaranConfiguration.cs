using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Persistence.Configurations
{
   public class MasterKategoriCaraPembayaranConfiguration:IEntityTypeConfiguration<MasterKategoriCaraPembayaran>
    {
       

        public void Configure(EntityTypeBuilder<MasterKategoriCaraPembayaran> builder)
        {
            builder.HasKey(e => e.NoUrutCaraBayar);

            builder.ToTable("MasterKategoriCaraPembayaran");

            builder.Property(e=>e.NoUrutCaraBayar).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.CaraPembayaran)
                .HasMaxLength(50)
                .IsUnicode(false);

            //  throw new NotImplementedException();
        }
    }
}
