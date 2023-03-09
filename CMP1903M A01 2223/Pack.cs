using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public static List<Card> pack = new List<Card>();
        public static List<Card> dealtCards = new List<Card>();
        public static List<Card> packFirstHalf = new List<Card>();
        public static List<Card> packSecondHalf = new List<Card>();

        // Pack Constructor
        public Pack()
        {
            int Card_suit = 0;
            int Card_value = 0;
            int Num_Of_Cards = 1;
            while (Num_Of_Cards <= 52)
            {
                pack.Add(new Card(Card_value, Card_suit));
                Card_value++;
                Num_Of_Cards++;
                if (Card_value == 13)
                {
                    Card_value = 0;
                    Card_suit++;
                }
            }
        }

        // Methods
        // This method shuffles the pack depending on which type of shuffle is selected
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            // Fisher Yates shuffle
            if (typeOfShuffle == 1)
            {
                var random = new Random();
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
            else if (typeOfShuffle == 2)
            {
                packFirstHalf.AddRange(pack.GetRange(0, 25));
                packSecondHalf.AddRange(pack.GetRange(25, 25));
                int Num_Of_Cards = 0;
                int Pack_Pointer = 0;
                while (Num_Of_Cards != 52)
                {
                    pack[Num_Of_Cards] = packFirstHalf[Pack_Pointer];
                    Pack_Pointer++;
                    pack[Num_Of_Cards] = packSecondHalf[Pack_Pointer];
                    Num_Of_Cards++;
                    Pack_Pointer++;
                }
                return true;
            }
            // This code checks if the input from the user is 3 and if it is doesnt shuffle the cards
            else if (typeOfShuffle == 3)
            {
                Console.WriteLine("You have selected that the pack is not to be shuffled therefore there is no change to the pack");
                return true;
            }
            else
            {
                return false;
            }
        }
        // This method will deal one card
        public static Card deal()
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
        public static List<Card> dealCard(int amount)
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
        public static void DisplayPack()
        {
            foreach (Card card in pack)
            {
                card.Show();

            }
        }
    }
}
 