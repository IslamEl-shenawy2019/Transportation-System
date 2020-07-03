using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transportation_System.Core.Domain;

namespace Transportation_System.Persistence.EntityConfiguration
{
    public class DriverVehicleConfiguration : IEntityTypeConfiguration<DriverVehicle>
    {
        public void Configure(EntityTypeBuilder<DriverVehicle> builder)
        {
            builder.HasKey(s => new { s.Vehicle_Id, s.Driver_Id });
            builder.HasOne(s => s.Driver)
                .WithMany(s => s.DriverVehicle)
                .HasForeignKey(s => s.Driver_Id);
            builder.HasOne(s => s.Vehicle)
                .WithMany(s => s.DriverVehicle)
                .HasForeignKey(s => s.Vehicle_Id);
        }
    }
}
