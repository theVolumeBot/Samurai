using System;
using System.Collections.Generic;

namespace EfSamurai.Domain
{
    public class Samurai
    {

        public Samurai()
        {
            Quote = new HashSet<Quote>();
            SamuraiBattle = new HashSet<SamuraiBattle>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public Haircut Haircut { get; set; }
        public string SecretIdentity { get; set; }

        public virtual ICollection<Quote> Quote { get; set; }
        public virtual ICollection<SamuraiBattle> SamuraiBattle { get; set; }
    }
}

