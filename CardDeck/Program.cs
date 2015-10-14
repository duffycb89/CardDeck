using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    Challenge: Design a Deck class and a Card class and write a function to shuffle a deck of cards.
    */

namespace CardDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a standard deck.
            var cardDeck = CreateDeck();
      
            try
            {
                //Create the Deck objec to call its function passing in our cards.
                Deck myDeck = new Deck();
                var cardsShuffled = myDeck.ShuffleDeck(cardDeck);

                //Show our newly shuffled deck.
                Console.WriteLine("CONGRATULATIONS!!!! Your deck is now shuffled!!!");
                foreach (var card in cardsShuffled)
                {
                    Console.WriteLine(card.CardNumber.ToString() + " of " + card.Suit + "\n");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION: ShuffleDeck encountered an exception.");
                Console.WriteLine(ex);
            }

            //Keep the console open
            Console.Read();
        }

        //TODO - Create a method overload so they can create a custom deck.
        //      Allow user to specify the suits and numbers for each suit.
        //Use this method to generate a deck to be shuffled.
        public static List<Card> CreateDeck()
        {
            //Specify what suits your deck uses. (Maybe you have a unique
            //  screaming goat deck.
            var cardTypes = new List<string>();
            cardTypes.Add("Spade");
            cardTypes.Add("Heart");
            cardTypes.Add("Club");
            cardTypes.Add("Diamond");

            //Create a dictionary for our return type.
            List<Card> myDeck = new List<Card>();

            //Create a basic 14 card and 4 suit deck.
            //Loop over each suit
            foreach (var suit in cardTypes)
            {
                //Loop once for each card number 2-10, J, Q, K, A = 13
                for (int i = 1; i < 14; i++)
                {
                    //Create a new card each time of the nested loop.
                    Card myCard = new Card();
                    myCard.Suit = suit;
                    myCard.CardNumber = i;

                    //Add the card to our deck.
                    myDeck.Add(myCard);
                    Console.Write("Our card is: " + myCard.CardNumber.ToString() + " of " + myCard.Suit + "\n");
                }
            }

            return myDeck;
        }



    }
}
