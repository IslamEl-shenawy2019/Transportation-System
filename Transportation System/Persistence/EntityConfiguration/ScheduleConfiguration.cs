using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transportation_System.Core.Domain;

namespace Transportation_System.Persistence.EntityConfiguration
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasMany(s => s.Tickets)
                .WithOne(s => s.Schedule)
                .HasForeignKey(s => s.Schedule_Id);
        }
    }
}
