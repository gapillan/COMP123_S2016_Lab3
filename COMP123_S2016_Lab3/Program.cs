using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(); // create a deck of cards 

            deck.Display(); // display the initial state of the deck 

            deck.Shuffle(); // shuffle the deck 
            deck.Display(); // display the deck after shuffling 

            Card cardDelt = deck.Deal();
            Console.WriteLine("Card Delt: {0} of {1}", cardDelt.Face, cardDelt.Suit);

            deck.Display();
        }
    }
}
