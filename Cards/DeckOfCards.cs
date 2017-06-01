using Cards.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cards.Models;
using Cards.Extenions;

namespace Cards
{
    public class DeckOfCards : ICards
    {

        public List<Card> CreateDeck()
        {
            //Create an index to control the order
            int indexId = 0;

            //Create the return list
            List<Card> cardDeck = new List<Card>();

            //Set up the loops
            foreach (var suit in new[] { "Spades", "Hearts", "Clubs", "Diamonds", })
            {
                for (int rank = 1; rank <= 13; rank++)
                {
                    if(rank == 1)
                    {
                        cardDeck.Add(new Card() { Rank = "Ace", RankValue = indexId, Suit = suit });
                    }
                    else if(rank == 11)
                    {
                        cardDeck.Add(new Card() { Rank = "Jack", RankValue = indexId, Suit = suit });
                    }
                    else if (rank == 12)
                    {
                        cardDeck.Add(new Card() { Rank = "Queen", RankValue = indexId, Suit = suit });
                    }
                    else if (rank == 13)
                    {
                        cardDeck.Add(new Card() { Rank = "King", RankValue = indexId, Suit = suit });
                    }
                    else
                    {
                        cardDeck.Add(new Card() { Rank = rank.ToString(), RankValue = indexId, Suit = suit });
                    }

                    indexId += 1;
                }
            }


            //Return the card deck
            return cardDeck;
        }

        public List<Card> OrderDeck(List<Card> cards)
        {

            //Order the deck and return it
            return cards.Select(a => a).OrderBy(o => o.RankValue).ToList();
        }

        public List<Card> ShuffleDeck(List<Card> cards)
        {
            //Shuffle the cards and return the deck
            cards.Shuffle();
            return cards;
        }
    }
}