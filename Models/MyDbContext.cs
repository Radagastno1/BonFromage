using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BonFromage.Models;

namespace BonFromage.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options) { }

        public DbSet<Dish> Dishes { get; set; } = default!;
        public DbSet<Adventage> Adventages { get; set; } = default!;
        public DbSet<Booking> Bookings { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source=mydatabase.db");
            // // options.UseInMemoryDatabase("MinDatabas");
            // var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
            // options.UseLoggerFactory(loggerFactory);
        }
    }
}
