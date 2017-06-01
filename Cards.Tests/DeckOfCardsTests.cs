using NUnit.Framework;
using Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cards.Models;

namespace Cards.Tests
{
    [TestFixture()]
    public class DeckOfCardsTests
    {
        private DeckOfCards sut;

        [SetUp]
        public void Setup()
        {
            sut = new DeckOfCards();
        }

        [Test()]
        public void CreateDeckTest()
        {
            //Arrange
            List<Card> response = new List<Card>();

            //Act
            response = sut.CreateDeck();

            //Assert
            Assert.That(response, Is.Not.Null);
            Assert.That(response.Count, Is.EqualTo(52));
            Assert.That(response[13].Rank, Is.EqualTo("Ace"));
        }

        [Test()]
        public void OrderDeckTest()
        {
            //Arrange
            List<Card> newDeck = sut.CreateDeck();
            List<Card> shuffledDeck = sut.ShuffleDeck(newDeck);
            List<Card> orderedDeck = new List<Card>();

            //Act
            orderedDeck = sut.OrderDeck(shuffledDeck);

            //Assert
            Assert.That(orderedDeck, Is.Not.Null);
            Assert.That(orderedDeck[5].RankValue, Is.EqualTo(5));
            Assert.That(orderedDeck[25].RankValue, Is.EqualTo(25));
        }

        [Test()]
        public void ShuffleDeckTest()
        {
            //Arrange
            List<Card> newDeck = sut.CreateDeck();
            List<Card> shuffledDeck = new List<Card>();

            //Act
            shuffledDeck = sut.ShuffleDeck(newDeck);

            //Assert
            Assert.That(shuffledDeck, Is.Not.Null);
            Assert.That(shuffledDeck[5].RankValue, Is.Not.EqualTo(5));
            Assert.That(shuffledDeck[25].RankValue, Is.Not.EqualTo(25));
        }
    }
}