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
    public class MasterLeaveTypeHRDConfiguration : IEntityTypeConfiguration<MasterLeaveTypeHRD>
    {
        public void Configure(EntityTypeBuilder<MasterLeaveTypeHRD> builder)
        {
            builder.ToTable("MasterLeaveTypeHRD", "MasterLeaveType");
            builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("MasterLeaveTypeHRD_hilo").IsRequired();


          builder.Property(e => e.LeaveTypeName).HasMaxLength(50)
               .IsUnicode(false);

        }
    }
}
