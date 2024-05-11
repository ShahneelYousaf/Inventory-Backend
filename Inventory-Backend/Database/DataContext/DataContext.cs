using Inventory_Backend.Database.Entities.User;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Inventory_Backend.Database.DataContext
{
    public class DataContext : DbContext
    {
        public bool? ShowArchive = false;
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Users>? Users { get; set; }
        public DbSet<Roles>? Roles { get; set; }
        public DbSet<LoginHistory>? LoginHistory { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
