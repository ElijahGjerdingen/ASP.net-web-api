using Microsoft.EntityFrameworkCore;

namespace Esports.API.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Moba - Tank" },
                new Category { Id = 2, Name = "Moba - Dps" },
                new Category { Id = 3, Name = "Moba - Support" },
                new Category { Id = 4, Name = "FPS - Hitscan" },
                new Category { Id = 5, Name = "FPS - Projectile" });

            modelBuilder.Entity<Player>().HasData(
                new Player { Id = 1, CategoryId = 1, Name = "Grunge Skater Jeans", GamerTag = "AWMGSJ", Price = 68, IsAvailable = true },
                new Player { Id = 2, CategoryId = 1, Name = "Polo Shirt", GamerTag = "AWMPS", Price = 35, IsAvailable = true },
                new Player { Id = 3, CategoryId = 1, Name = "Skater Graphic T-Shirt", GamerTag = "AWMSGT", Price = 33, IsAvailable = true },
                new Player { Id = 4, CategoryId = 1, Name = "Slicker Jacket", GamerTag = "AWMSJ", Price = 125, IsAvailable = true },
                new Player { Id = 5, CategoryId = 1, Name = "Thermal Fleece Jacket", GamerTag = "AWMTFJ", Price = 60, IsAvailable = true },
                new Player { Id = 6, CategoryId = 1, Name = "Unisex Thermal Vest", GamerTag = "AWMUTV", Price = 95, IsAvailable = true },
                new Player { Id = 7, CategoryId = 1, Name = "V-Neck Pullover", GamerTag = "AWMVNP", Price = 65, IsAvailable = true },
                new Player { Id = 8, CategoryId = 1, Name = "V-Neck Sweater", GamerTag = "AWMVNS", Price = 65, IsAvailable = true },
                new Player { Id = 9, CategoryId = 1, Name = "V-Neck T-Shirt", GamerTag = "AWMVNT", Price = 17, IsAvailable = true },
                new Player { Id = 10, CategoryId = 2, Name = "Bamboo Thermal Ski Coat", GamerTag = "AWWBTSC", Price = 99, IsAvailable = true },
                new Player { Id = 11, CategoryId = 2, Name = "Cross-Back Training Tank", GamerTag = "AWWCTT", Price = 0, IsAvailable = false },
                new Player { Id = 12, CategoryId = 2, Name = "Grunge Skater Jeans", GamerTag = "AWWGSJ", Price = 68, IsAvailable = true },
                new Player { Id = 13, CategoryId = 2, Name = "Slicker Jacket", GamerTag = "AWWSJ", Price = 125, IsAvailable = true },
                new Player { Id = 14, CategoryId = 2, Name = "Stretchy Dance Pants", GamerTag = "AWWSDP", Price = 55, IsAvailable = true },
                new Player { Id = 15, CategoryId = 2, Name = "Ultra-Soft Tank Top", GamerTag = "AWWUTT", Price = 22, IsAvailable = true },
                new Player { Id = 16, CategoryId = 2, Name = "Unisex Thermal Vest", GamerTag = "AWWUTV", Price = 95, IsAvailable = true },
                new Player { Id = 17, CategoryId = 2, Name = "V-Next T-Shirt", GamerTag = "AWWVNT", Price = 17, IsAvailable = true },
                new Player { Id = 18, CategoryId = 3, Name = "Blueberry Mineral Water", GamerTag = "MWB", Price = 2.8M, IsAvailable = true },
                new Player { Id = 19, CategoryId = 3, Name = "Lemon-Lime Mineral Water", GamerTag = "MWLL", Price = 2.8M, IsAvailable = true },
                new Player { Id = 20, CategoryId = 3, Name = "Orange Mineral Water", GamerTag = "MWO", Price = 2.8M, IsAvailable = true },
                new Player { Id = 21, CategoryId = 3, Name = "Peach Mineral Water", GamerTag = "MWP", Price = 2.8M, IsAvailable = true },
                new Player { Id = 22, CategoryId = 3, Name = "Raspberry Mineral Water", GamerTag = "MWR", Price = 2.8M, IsAvailable = true },
                new Player { Id = 23, CategoryId = 3, Name = "Strawberry Mineral Water", GamerTag = "MWS", Price = 2.8M, IsAvailable = true },
                new Player { Id = 24, CategoryId = 4, Name = "In the Kitchen with H+ Sport", GamerTag = "PITK", Price = 24.99M, IsAvailable = true },
                new Player { Id = 25, CategoryId = 5, Name = "Calcium 400 IU (150 tablets)", GamerTag = "SC400", Price = 9.99M, IsAvailable = true },
                new Player { Id = 26, CategoryId = 5, Name = "Flaxseed Oil 100 mg (90 capsules)", GamerTag = "SFO100", Price = 12.49M, IsAvailable = true },
                new Player { Id = 27, CategoryId = 5, Name = "Iron 65 mg (150 caplets)", GamerTag = "SI65", Price = 13.99M, IsAvailable = true },
                new Player { Id = 28, CategoryId = 5, Name = "Magnesium 250 mg (100 tablets)", GamerTag = "SM250", Price = 12.49M, IsAvailable = true },
                new Player { Id = 29, CategoryId = 5, Name = "Multi-Vitamin (90 capsules)", GamerTag = "SMV", Price = 9.99M, IsAvailable = true },
                new Player { Id = 30, CategoryId = 5, Name = "Vitamin A 10,000 IU (125 caplets)", GamerTag = "SVA", Price = 11.99M, IsAvailable = true },
                new Player { Id = 31, CategoryId = 5, Name = "Vitamin B-Complex (100 caplets)", GamerTag = "SVB", Price = 12.99M, IsAvailable = true },
                new Player { Id = 32, CategoryId = 5, Name = "Vitamin C 1000 mg (100 tablets)", GamerTag = "SVC", Price = 9.99M, IsAvailable = true },
                new Player { Id = 33, CategoryId = 5, Name = "Vitamin D3 1000 IU (100 tablets)", GamerTag = "SVD3", Price = 12.49M, IsAvailable = true });

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Email = "elijah.gjerdingen@gmail.com" },
                new User { Id = 2, Email = "craig.gjerdingen@gmail.com" });
        }
    }
}
