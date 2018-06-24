using LNBServer.Models;
using System;
using System.Linq;

namespace LNBServer.Data
{
    public static class LNDBInitializer
    {
        public static void Initialize(LNDBContext context)
        {
            context.Database.EnsureCreated();

            // If we have volumes then the database has been seeded already
            if (context.Volumes.Any())
            {
                return;
            }
        }
    }
}
