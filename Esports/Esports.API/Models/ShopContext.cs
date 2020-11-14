using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esports.API.Models
{
    public class ShopContext : DbContext
    {
        
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasMany(c => c.Players).WithOne(a => a.Category).HasForeignKey(a => a.CategoryId);
            modelBuilder.Entity<Team>().HasMany(t => t.Players);
            modelBuilder.Entity<Team>().HasOne(t => t.User);
            modelBuilder.Entity<User>().HasMany(u => u.Teams).WithOne(t => t.User).HasForeignKey(t => t.UserId);

            modelBuilder.Seed();

        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
