using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transportation_System.Core.Domain;
using Transportation_System.Persistence.EntityConfiguration;

namespace Transportation_System.Data
{
    public class TransportContext: IdentityDbContext<User,IdentityRole,string>
    {
        public TransportContext(DbContextOptions<TransportContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new DriverConfiguration());
            builder.ApplyConfiguration(new DriverVehicleConfiguration());
            builder.ApplyConfiguration(new PassengerConfiguration());
            builder.ApplyConfiguration(new ScheduleConfiguration());
            builder.ApplyConfiguration(new VehicleConfiguration());
            //builder.ApplyConfiguration(new PromotionsConfiguration());
            //builder.ApplyConfiguration(new TicketConfiguration());
            base.OnModelCreating(builder);
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<DriverVehicle> DriverVehicle { get; set; }
        public DbSet<Passenger>  Passengers { get; set; }
        public DbSet<Promotions> Promotions { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
    }
}
