using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        //fields
        public static List<Card> pack = new List<Card>();
        public static List<Card> dealtCards = new List<Card>();
        public static List<Card> packHalf = new List<Card>();
      

        // Pack Constructor
        public Pack()
        {

            int Card_suit = 0; // this keeps track of what suit it is
            int Card_value = 0; // this keeps track of the cards value
            int Num_Of_Cards = 1; //This keeps track of how many cards have been created
            while (Num_Of_Cards <= 52) // While there is less than the number of cards in a pack this will run
            {
                pack.Add(new Card(Card_value, Card_suit)); // This adds the card to the pack depending on the current value and suit
                Card_value++; // This adds to the card value
                Num_Of_Cards++; // This adds to the number of cards made
                if (Card_value == 13) // This makes it so that when it reaches the required amount of cards in the suit
                {
                    Card_value = 0; // It will reset the card value to 0
                    Card_suit++; // And add one to the suit so changes suit
                }
            }
        }

        // Methods
        // This method shuffles the pack depending on which type of shuffle is selected
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            // Fisher Yates shuffle
            if (typeOfShuffle == 1) // This checks if the type of shuffles value is one, if it is it will continue with the function
            {
                var random = new Random(); // This sets the value of the random variable to a random number
                for (int Num_Of_Cards = pack.Count; Num_Of_Cards > 1; Num_Of_Cards--)
                {
                    int Card_To_Swap = random.Next(Num_Of_Cards);

                    Card temp = pack[Card_To_Swap];
                    pack[Card_To_Swap] = pack[Num_Of_Cards - 1];
                    pack[Num_Of_Cards - 1] = temp;
                }
                return true;
            }
            //Riffle Shuffle
            else if (typeOfShuffle == 2) // if the value is 2 it will proceed with this function
            {
                int Pack_Pointer = 0;
                while (Pack_Pointer != pack.Count / 2)
                {
                    packHalf.Add(pack[Pack_Pointer]);
                    packHalf.Add(pack[Pack_Pointer + (pack.Count/2)]);
                    Pack_Pointer++;
                }
                pack = packHalf;
                return true;
            }
            // This code checks if the input from the user is 3 and if it is doesnt shuffle the cards
            else if (typeOfShuffle == 3)
            {
                Console.WriteLine("You have selected that the pack is not to be shuffled therefore there is no change to the pack"); // This will write to the console that the pack hasnt been shuffled
                return true;
            }
            else
            {
                return false;
            }
        }
        // This method will deal one card
        public static Card Deal()
        {
            if (pack.Count == 0)
            {
                Console.WriteLine("The pack is empty");
                return null;
            }
            else
            {
                Card FirstCard = pack[0];
                pack.RemoveAt(0);
                return FirstCard;
                

            }

        }
        // This method deals an amount of cards specified by the user
        public static List<Card> DealCard(int amount)
        {
            if (pack.Count == 0)
            {
                Console.WriteLine("The pack is empty");
                return null;
            }
            else
            {
                int packPointer = 1;
                while (packPointer <= amount)
                {
                    Card FirstCard = pack[0];
                    pack.RemoveAt(0);
                    packPointer++;
                    dealtCards.Add(FirstCard);
                }
                return dealtCards;
            }

        }
        public static void DisplayPack() // This method displays the pack
        {
            foreach (Card card in pack)
            {
                card.Show(); // This calls the show function in the Card file

            }
        }
    }
}
 