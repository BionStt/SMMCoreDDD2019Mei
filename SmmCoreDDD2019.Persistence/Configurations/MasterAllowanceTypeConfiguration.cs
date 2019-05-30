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
    public class MasterAllowanceTypeConfiguration : IEntityTypeConfiguration<MasterAllowanceType>
    {
        public void Configure(EntityTypeBuilder<MasterAllowanceType> builder)
        {
            builder.ToTable("MasterAllowanceType");


        }
    }
}
