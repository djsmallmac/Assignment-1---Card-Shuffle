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
            Pack Deck = new Pack();
            Pack.DisplayPack();

            //The next section displays different shuffles

            //This displays the Fisher-Yates shuffle
            //Console.WriteLine(" This is the Fisher-Yates Shuffle: ");
            //Pack.shuffleCardPack(1);
            //Pack.DisplayPack();

            //This displays the Riffle Shuffle
            //Console.WriteLine("This is the Riffle Shuffle");
            //Pack.shuffleCardPack(2);
            //Pack.DisplayPack();


            //This is not Shuffled
            //Console.WriteLine("This is the pack not shufffled: ");
            //Pack.shuffleCardPack(3);
            //Pack.DisplayPack();

            //This section displays dealing the cards
            Console.WriteLine("This is dealing one card");
            Pack.Deal().Show();
            Console.WriteLine("This is the rest of the deck");
            Pack.DisplayPack(); 
        
        }
    }
}
