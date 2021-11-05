using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.SalesMarketing.Domain;

namespace SumberMas2015.SalesMarketing.InfrastructureData.Configuration
{
    public class PermohonanFakturConfiguration : IEntityTypeConfiguration<PermohonanFaktur>
    {
        public void Configure(EntityTypeBuilder<PermohonanFaktur> builder)
        {
            builder.ToTable("PermohonanFaktur");
        }
    }
}
