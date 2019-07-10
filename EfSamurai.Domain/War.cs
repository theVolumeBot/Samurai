using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
   public class War
    {

        public War()
        {
            SamuraiBattle = new HashSet<SamuraiBattle>();
  
        }
        // namn, beskrivning, brutal(true/false), start-datum, slut-datum
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Description { get; set; }
        public bool Brutal { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }

        public virtual ICollection<SamuraiBattle> SamuraiBattle { get; set; }
    }
}
