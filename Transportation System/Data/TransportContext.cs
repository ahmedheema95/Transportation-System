using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transportation_System.Core.Domain;

namespace Transportation_System.Data
{
    public class TransportContext: IdentityDbContext
    {
        public TransportContext(DbContextOptions<TransportContext> options)
            : base(options)
        {
        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Passenger>  Passengers { get; set; }
        public DbSet<Promotions> Promotions { get; set; }
        public DbSet<Tickets>  Tickets { get; set; }
        public DbSet<Schedule>  Schedules { get; set; }
    }
}
