using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.SalesMarketing.Domain.EnumInEntity;

namespace SumberMas2015.SalesMarketing.InfrastructureData.Configuration
{
    public class AgamaConfiguration : IEntityTypeConfiguration<Agama>
    {
        public void Configure(EntityTypeBuilder<Agama> builder)
        {
            builder.ToTable("Agama");

            builder.HasData(
               Agama.AddAgama("ISLAM"),
                Agama.AddAgama("HINDU"),
                 Agama.AddAgama("KRISTEN"),
                  Agama.AddAgama("KATOLIK"),
                   Agama.AddAgama("BUDDHA"),
                    Agama.AddAgama("KONGHUCU")
               );


        }
    }
}
