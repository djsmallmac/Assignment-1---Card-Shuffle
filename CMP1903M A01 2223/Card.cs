using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    //Base for the Card class.
    //Value: numbers 1 - 13
    //Suit: numbers 1 - 4
    //The 'set' methods for these properties could have some validation
    {
        readonly string[] Values = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        readonly string[] Suits = { "Spades", "Clubs", "Diamonds", "Hearts" };

        private int _value;
        private int _suit;

        public int Value
        {
            get { return _value; }

            set
            {
                _value = value;
            }
        }
        public int Suit
        {
            get { return _suit; }

            set
            {
                _suit = value;
            }
        }
        public Card(int value, int suit)
        {
            Value = value;
            Suit = suit;
        }
        public void Show()
        {
            Console.WriteLine(Values[Value] + " of " + Suits[Suit]);
        }

    }
}