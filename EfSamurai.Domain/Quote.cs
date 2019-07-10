using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
    public class Quote
    {
        public int Id { get; set; }
        public string TheQuote { get; set; }
        public virtual Samurai Samurai { get; set; }
        public QuoteRank QuoteRank { get; set; }
    }
}
