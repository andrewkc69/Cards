using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cards.Models
{
    public class Card
    {
        public int RankValue {  get; set; }
        public string Rank { get; set; }
        public string Suit { get; set; }
    }
}