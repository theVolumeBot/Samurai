using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
   public class SamuraiBattle
    {
        public int Id { get; set; }
        public Samurai Samurai { get; set; }
        public War War { get; set; }
        public BattleLog BattleLog { get; set; }

    }
}
