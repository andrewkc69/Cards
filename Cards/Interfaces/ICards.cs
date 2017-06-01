using Cards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Interfaces
{
    public interface ICards
    {
        List<Card> CreateDeck();
        List<Card> OrderDeck(List<Card> cards);
        List<Card> ShuffleDeck(List<Card> cards);
    }
}
