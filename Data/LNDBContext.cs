using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LNBServer.Data
{
    using LNBServer.Models;

    class LNDBContext : DbContext
    {
        public DbSet<LNPublisher> Publishers { get; set; }
        public DbSet<LNLabel> Labels { get; set; }
        public DbSet<LNSeries> Series { get; set; }
        public DbSet<LNVolume> Volumes { get; set; }

        public LNDBContext(DbContextOptions<LNDBContext> options) : base(options)
        {
        }
    }
}
