using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Testing
    {
        public static void Test()
        {
            //This Displays the pack
            Console.WriteLine("This is card pack: ");
            Pack Deck = new Pack();
            Pack.DisplayPack();

            //The next section displays different shuffles

            //This displays the Fisher-Yates shuffle by calling the required functions
            Console.WriteLine(" This is the Fisher-Yates Shuffle: ");
            Pack.shuffleCardPack(1);
            Pack.DisplayPack();

            //This displays the Riffle Shuffle by calling the required functions
            Console.WriteLine("This is the Riffle Shuffle: ");
            Pack.shuffleCardPack(2);
            Pack.DisplayPack();


            //This is not Shuffled by calling the required functions
            Console.WriteLine("This is the pack not shufffled: ");
            Pack.shuffleCardPack(3);
            Pack.DisplayPack();

            //This section displays dealing the cards

            //This is dealing one card by calling the required functions
            Console.WriteLine("This is dealing one card: ");
            Pack.Deal().Show();
            Console.WriteLine("This is the rest of the deck: ");
            Pack.DisplayPack();

            //This is dealing multiple cards by calling the required functions 
            Console.WriteLine("This is dealing multiple cards: ");
            Pack.DealCard(5);
            foreach (Card card in Pack.dealtCards)
            {
                card.Show();
            }
            Console.WriteLine("This is the rest of the deck: ");
            Pack.DisplayPack();

        }
    }
}
