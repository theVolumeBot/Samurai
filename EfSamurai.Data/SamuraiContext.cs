using EfSamurai.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace EfSamurai.Data
{
    public class SamuraiContext : DbContext
    {
         public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<BattleEvent> BattleEvent { get; set; }
        public DbSet<BattleLog> BattleLog { get; set; }
        public DbSet<SamuraiBattle> SamuraiBattle { get; set; }
        public DbSet<Battle> Battle { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=Samurai;Integrated Security=True;Pooling=False");
        }

     
    }
    }

