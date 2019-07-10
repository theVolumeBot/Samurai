using EfSamurai.Domain;
using System;
using System.Collections.Generic;

namespace AddingToDataBase
{
    class Program
    {
        static void Main(string[] args)
        {

            var dataAccess = new DataAccess();
             dataAccess.DropDatabase();
            dataAccess.CreateDataBase();
            //var sam = new Samurai
            //{
            //    Name = "Sven",
            //    Quotes = new List<Quote>()
            //};
            //dataAccess.Add(sam);
            //dataAccess.AddAwesomeQuoteToSamurai("awesomeee", sam);
            //dataAccess.ClearContext();
            //Samurai result = dataAccess.FindByName("Sven");
            //Console.WriteLine(result.Name);
            //Console.WriteLine(result.Id);
            //Console.WriteLine(result.Quotes.Count);
    
        }
    }
}
