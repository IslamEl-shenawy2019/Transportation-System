using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transportation_System.Core.Domain;

namespace Transportation_System.Persistence.EntityConfiguration
{
    public class DriverConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.HasMany(s => s.Schedules)
                .WithOne(s => s.Driver)
                .HasForeignKey(s => s.Driver_Id);
        }
    }
}
