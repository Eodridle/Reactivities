using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        { 
        }

        public DbSet<Value> Values { get; set; } //Value is the Value.cs class that we created. Its pulling in this data

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
                .HasData(
                    new Value {Id = 1, Name = "Value 101"},
                    new Value {Id = 2, Name = "Value 102"},
                    new Value {Id = 3, Name = "Value 103"}
                );
            // This method OnModelCreating is a built-in method to the DBContext class. The keyword override, overrides
            // the method and will run this instead. This will put some seed data into the db.
        }
    }
}
