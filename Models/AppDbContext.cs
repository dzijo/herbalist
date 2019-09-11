using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herbalist.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<HerbInfo> HerbInfos { get; set; }
        public DbSet<HerbCount> HerbCounts { get; set; }
        public DbSet<PotionRecipe> PotionRecipes { get; set; }
        public DbSet<HerbAmount> Herbs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<HerbCount>()
                .HasKey(c => new { c.HerbId, c.UserName });

            builder.Seed();
        }
    }
}
