using Cards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cards
{
    public partial class Index : System.Web.UI.Page
    {
        private List<Card> deck = new List<Card>();
        DeckOfCards cards = new DeckOfCards();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Create a new deck
            deck = cards.CreateDeck();

            //Update Status
            lbDeckStatus.Text = "New Deck created!!";
        }

        protected void btnShuffle_Click(object sender, EventArgs e)
        {
            //Create a list to hold the shuffled deck
            List<Card> shuffledDeck = cards.ShuffleDeck(deck);

            //Create the string to show the card list
            StringBuilder cardText = new StringBuilder();

            foreach(Card c in shuffledDeck)
            {
                cardText.AppendLine(c.Rank + " of " + c.Suit + "</br>");
            }

            //Update card labels
            lbDeckCards.Text = cardText.ToString();
            lbDeckStatus.Text = "Cards Shuffled!";
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            //Create a list to hold the ordered deck
            List<Card> orderedDeck = cards.OrderDeck(deck);

            //Create the string to show the card list
            StringBuilder cardText = new StringBuilder();

            foreach (Card c in orderedDeck)
            {
                cardText.AppendLine(c.Rank + " of " + c.Suit + "</br>");
            }

            //Update card labels
            lbDeckCards.Text = cardText.ToString();
            lbDeckStatus.Text = "Cards Ordered!";
        }
    }
}