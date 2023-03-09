using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    //Base for the Card class.

    {
        //These arrays hold the suits and values of the cards
        readonly string[] Values = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        readonly string[] Suits = { "Spades", "Clubs", "Diamonds", "Hearts" };

        private int Card_value;
        private int Card_suit;


        //The get and set methods for the card values and suits
        public int Value
        {
            get { return Card_value; }

            set
            {
                Card_value = value;
            }
        }
        public int Suit
        {
            get { return Card_suit; }

            set
            {
                Card_suit = value;
            }
        }

        //Card Constructor
        public Card(int value, int suit)
        {
            Value = value;
            Suit = suit;
        }
        public void Show() // This retrieves the values and suits in the pack
        {
            Console.WriteLine(Values[Value] + " of " + Suits[Suit]); // This displays the value and suit of a card and writes it to the console
        }

    }
}