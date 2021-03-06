using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Project.Server.Configurations.Entities;
using Project.Server.Models;
using Project.Shared.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Attraction> Attractions { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<ItenaryItem> ItenaryItems { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Country> Country { get; set; }
      
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AttractionSeedConfiguration());

            builder.ApplyConfiguration(new CountrySeedConfiguration());

            builder.ApplyConfiguration(new HotelSeedConfiguration());

            builder.ApplyConfiguration(new LocationSeedConfiguration());

            builder.ApplyConfiguration(new PaymentSeedConfiguration());

            builder.ApplyConfiguration(new RoleSeedConfiguration());

            builder.ApplyConfiguration(new UserRoleSeedConfiguration());

            builder.ApplyConfiguration(new UserSeedConfiguration());
        }
    }
}
