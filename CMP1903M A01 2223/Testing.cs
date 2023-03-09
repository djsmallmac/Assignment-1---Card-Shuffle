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
            Console.WriteLine(" \n This is card pack: \n ");
            Pack Deck = new Pack();
            Pack.DisplayPack();

            //The next section displays different shuffles

            //This displays the Fisher-Yates shuffle by calling the required functions
            Console.WriteLine(" \n This is the Fisher-Yates Shuffle: \n ");
            Pack.shuffleCardPack(1);
            Pack.DisplayPack();

            //This displays the Riffle Shuffle by calling the required functions
            Console.WriteLine(" \nThis is the Riffle Shuffle: \n ");
            Pack.shuffleCardPack(2);
            Pack.DisplayPack();


            //This is not Shuffled by calling the required functions
            Console.WriteLine(" \n This is the pack not shuffled: \n ");
            Pack.shuffleCardPack(3);
            Pack.DisplayPack();

            //This section displays dealing the cards

            //This is dealing one card by calling the required functions
            Console.WriteLine(" \nThis is dealing one card: \n ");
            Pack.Deal().Show();
            Console.WriteLine(" \n This is the rest of the deck: \n");
            Pack.DisplayPack();

            //This is dealing multiple cards by calling the required functions 
            Console.WriteLine(" \n This is dealing multiple cards: \n ");
            Pack.DealCard(5);
            foreach (Card card in Pack.dealtCards)
            {
                card.Show();
            }
            Console.WriteLine(" \nThis is the rest of the deck: \n ");
            Pack.DisplayPack();

        }
    }
}
