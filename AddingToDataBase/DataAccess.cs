using EfSamurai.Data;
using EfSamurai.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddingToDataBase
{
    class DataAccess
    {
        private SamuraiContext samuraiContext = new SamuraiContext();


        public void SaveChanges()
        {
            samuraiContext.SaveChanges();
        }

        public Samurai GetSamuraiOnName(string name)
        {
            var samurais = samuraiContext.Samurais;
            Samurai samurai = samurais.FirstOrDefault(a => a.Name == name);
            return samurai;
       
        }

        internal void AddQuote(string quote, Samurai samurai)
        {
            samurai.Quote.Add(new Quote {TheQuote = quote, QuoteRank = QuoteRank.Cheesy, Samurai = samurai });
            SaveChanges();
        }

        public void Remove(Samurai samurai)
        {
            var Samurai = samuraiContext.Samurais.FirstOrDefault(a => a == samurai);
            samuraiContext.Remove(samurai);
            SaveChanges();
        }


        public void DropDataBase()
        {
            samuraiContext.Database.EnsureDeleted();
            SaveChanges();
        }

        public void CreateDataBase()
        {
            samuraiContext.Database.EnsureCreated();
            SaveChanges();
        }

        public void AddSamurai(string name, Haircut haircut, string secretIdentity)
        {
            var samurais = samuraiContext.Samurais;
            samurais.Add(new Samurai { Name = name, Haircut = haircut, SecretIdentity = secretIdentity });
            SaveChanges();
        }

        public Samurai GetSamuraiOnId(int id)
        {
            var samurais = samuraiContext.Samurais;
            Samurai samurai = samurais.FirstOrDefault(a => a.Id == id);
            return samurai;
        }
    }
}
