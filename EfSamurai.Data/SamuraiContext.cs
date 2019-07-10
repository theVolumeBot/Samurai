using EfSamurai.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace EfSamurai.Data
{
    public class SamuraiContext : DbContext
    {
         public DbSet<Samurai> Samurais { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=Samurai;Integrated Security=True;Pooling=False");
        }

     
    }
    }

