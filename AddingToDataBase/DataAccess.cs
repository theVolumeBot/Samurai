using EfSamurai.Data;
using EfSamurai.Domain;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AddingToDataBase
{
  public  class DataAccess
    {
        private SamuraiContext samuraiContext = new SamuraiContext();


        public void SaveChanges()
        {
            samuraiContext.SaveChanges();
        }

        public Samurai FindByName(string name)
        {
            var samurais = samuraiContext.Samurais;
            Samurai samurai = samurais
                .Include(x => x.Quotes)
                .Include(x => x.SamuraiBattles)
                .Include(x => x.SecretIdentity)
                .Include(x => x.SamuraiBattles)
                .FirstOrDefault(a => a.Name == name);
           
            return samurai;

        }

        public Samurai FindByRealName(string name)
        {
            var samurais = samuraiContext.Samurais;
            Samurai samurai = samurais
                .Include(x => x.Quotes)
                .Include(x => x.SamuraiBattles)
                .FirstOrDefault(a => a.SecretIdentity.RealName == name);

            return samurai;

        }

        public void ClearContext()
        {
            samuraiContext = new SamuraiContext();
            SaveChanges();
        }

       

        public void AddAwesomeQuoteToSamurai(string text, Samurai samurai)
        {
            samurai.Quotes.Add(new Quote { Text = text, Samurai = samurai });
            SaveChanges();
        }

        private bool CheckIfQuoteIsTaken(string quote)
        {
            var quoteReturn = samuraiContext.Quotes.FirstOrDefault(a => a.Text == quote);
            try
            {
                quoteReturn.GetType();
                return true;
            }
            catch
            {
                return false;
            }


        }
        public void ChangeRealName(string name, string newRealName)
        {
            Samurai sam = FindByName(name);
            sam.SecretIdentity.RealName = newRealName;
            SaveChanges();
        }

        public void UpdateSamuraiName(string oldName, string newName)
        {
            Samurai sam = FindByName(oldName);
            sam.Name = newName;
            SaveChanges();
        }

        public void Remove(Samurai samurai)
        {
            var Samurai = samuraiContext.Samurais.FirstOrDefault(a => a == samurai);
            samuraiContext.Remove(samurai);
            SaveChanges();
        }

        public void ClearDatabase()
        {
            DropDatabase();
            CreateDataBase();
            SaveChanges();
        }

   
        public void DropDatabase()
        {
            samuraiContext.Database.EnsureDeleted();
            SaveChanges();
        }

        public void CreateDataBase()
        {
            samuraiContext.Database.EnsureCreated();
            SaveChanges();
        }

        public void Add(Samurai samurai)
        {
            var samurais = samuraiContext.Samurais;
            samurais.Add(samurai);
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
