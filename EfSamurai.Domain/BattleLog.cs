using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
  public  class BattleLog
    {

        public BattleLog()
        {
            BattleEvents = new HashSet<BattleEvent>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BattleEvent> BattleEvents  { get; set; }

    }
}
