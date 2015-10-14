using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck
{
    class Deck
    {
        public List<Card> ShuffleDeck(List<Card> cards)
        {
            //Take a list of cards and shuffle them.
            Random myRandom = new Random();
            List<Card> cardShuffled = new List<Card>();

            int rInt = 0;

            while (cards.Count > 0)
            {
                //Create a random number from 0 to the number of cards in our list.
                rInt = myRandom.Next(0, cards.Count);

                //Add the random card to our shuffled deck
                cardShuffled.Add(cards[rInt]);

                //Remove the card from the old deck
                //cards.Remove(card);
                cards.RemoveAt(rInt);
            }

            return cardShuffled;
        }

        //TODO - Possible improvement add an overload that accepts an array instead.
        //public void ShuffleDeck(Card[] cards)
        //{
        //    //Take an array of cards and shuffle them.

        //}

    }
}
