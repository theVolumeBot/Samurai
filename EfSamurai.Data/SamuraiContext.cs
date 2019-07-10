﻿using EfSamurai.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace EfSamurai.Data
{
    public class SamuraiContext : DbContext
    {
         public DbSet<Samurai> Samurais { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = EfSamurai;");
        }
    }
    }

