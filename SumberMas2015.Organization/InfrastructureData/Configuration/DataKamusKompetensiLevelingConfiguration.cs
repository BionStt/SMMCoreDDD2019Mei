﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.Organization.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.InfrastructureData.Configuration
{
    public class DataKamusKompetensiLevelingConfiguration : IEntityTypeConfiguration<DataKamusKompetensiLeveling>
    {
        public void Configure(EntityTypeBuilder<DataKamusKompetensiLeveling> builder)
        {
            builder.ToTable("DataKamusKompetensiLeveling");
            builder.HasKey(x => x.DataKamusKompetensiLevelingId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();



        }
    }
}
