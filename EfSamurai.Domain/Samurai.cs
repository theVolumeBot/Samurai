using System;
using System.Collections.Generic;

namespace EfSamurai.Domain
{
    public class Samurai
    {

        public Samurai()
        {
            Quotes = new HashSet<Quote>();
            SamuraiBattles = new HashSet<SamuraiBattle>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public HairStyle HairStyle { get; set; }
        public SecretIdentity SecretIdentity { get; set; }

        public virtual ICollection<Quote> Quotes { get; set; }
        public virtual ICollection<SamuraiBattle> SamuraiBattles { get; set; }
    }
}

