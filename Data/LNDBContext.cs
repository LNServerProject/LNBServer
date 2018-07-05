using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LNBServer.Data
{
    using LNBServer.Models;

    public class LNDBContext : DbContext
    {
        public DbSet<LNLabel> Labels { get; set; }
        public DbSet<LNPublisher> Publishers { get; set; }
        public DbSet<LNSeries> Series { get; set; }
        public DbSet<LNVolume> Volumes { get; set; }

        public LNDBContext(DbContextOptions<LNDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Define composite key.
            builder.Entity<LNLabel>()
                .HasKey(x => x.Id);

            // Arrays of strings aren't supported by EF, so need special trick
            builder.Entity<LNSeries>()
                .Property<string>("AssociatedTitlesCollection")
                .HasField("_associatedTitles");

            // ISBN is just a number. Database is just a place.
            builder.Entity<LNVolume>()
                .Property(e => e.ISBN)
                .HasConversion(new CastingConverter<ISBN, int>());
            // Same issue as with the associated titles in LNSeries
            builder.Entity<LNVolume>()
                .Property<string>("AssociatedTitlesCollection")
                .HasField("_associatedTitles");
        }
    }
}
