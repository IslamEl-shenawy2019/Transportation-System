using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transportation_System.Core.Domain;

namespace Transportation_System.Persistence.EntityConfiguration
{
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.HasMany(s => s.Tickets)
                .WithOne(s => s.Passenger)
                .HasForeignKey(s => s.Passenger_Id);

            builder.HasMany(s => s.Promotions)
                .WithOne(s => s.Passenger)
                .HasForeignKey(s => s.Passenger_Id);
        }
    }
}
