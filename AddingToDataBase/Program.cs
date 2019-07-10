using EfSamurai.Domain;
using System;

namespace AddingToDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccess dataAccess = new DataAccess();
              //dataAccess.AddSamurai("mak", Haircut.Western, "Marcus");
            //var samurai = dataAccess.GetSamuraiOnId(1);
            var samurai = dataAccess.GetSamuraiOnName("mak");
            dataAccess.AddQuote("The way of the sword", samurai);
          //  dataAccess.Remove();
        }
    }
}
