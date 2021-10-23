using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataKontrakAngsuranConfiguration : IEntityTypeConfiguration<DataKontrakAngsuran>
    {
        public void Configure(EntityTypeBuilder<DataKontrakAngsuran> builder)
        {
            builder.ToTable("DataKontrakAngsuran", "DataAvalist");

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.DataKontrakKreditId);
            builder.Property(e => e.AngsuranKe).HasMaxLength(4).IsUnicode(false);
            builder.Property(e => e.NoKwitansi).HasMaxLength(30).IsUnicode(false);
            builder.Property(e => e.TanggalAngsuran).HasColumnType("datetime");
            builder.Property(e => e.Angsuran).HasColumnType("money");
            builder.Property(e => e.Pokok).HasColumnType("money");
            builder.Property(e => e.Bunga).HasColumnType("money");
            builder.Property(e => e.SisaPokok).HasColumnType("money");
            builder.Property(e => e.SisaBunga).HasColumnType("money");
            builder.Property(e => e.Denda).HasColumnType("money");
            builder.Property(e => e.DiskonDenda).HasColumnType("money");
            builder.Property(e => e.TitipanAngsuran).HasColumnType("money");
            builder.Property(e => e.TanggalBayarAngsuran).HasColumnType("datetime");
            builder.Property(e => e.JumlahPembayaran).HasColumnType("money");
            builder.Property(e => e.CaraBayar).HasMaxLength(3).IsUnicode(false);
            builder.Property(e => e.BiayaAdministrasi).HasColumnType("money");
            builder.Property(e => e.PenagihId).HasMaxLength(4).IsUnicode(false);







        }
    }
}
