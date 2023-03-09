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
                for (int Num_Of_Cards = pack.Count ; Num_Of_Cards > 1; Num_Of_Cards--) // a for loop which as long as the number of cards is bigger than one will loop through the following
                {
                    int Card_To_Swap = random.Next(Num_Of_Cards); // This defines card to swap as a random integer smaller than or equal to the number of cards in the pack

                    Card temp = pack[Card_To_Swap]; // creates a temporary file to hold the random card that was selected
                    pack[Card_To_Swap] = pack[Num_Of_Cards - 1]; //The card that has been randomly selected is removed from the pack so there are no duplicates
                    pack[Num_Of_Cards - 1] = temp; // copies the temporary file into the pack
                }
                return true;
            }
            //Riffle Shuffle
            else if (typeOfShuffle == 2) // if the value passed through the function is 2 it will proceed with this function
            {
                int Pack_Pointer = 0; // Sets the value of the pack pointer to zero
                while (Pack_Pointer != pack.Count / 2) // While the pack pointer does not equal to the size of the pack divided by two  this loop will run
                {
                    //These lines adds the cards corresponding to the pack pointer to a temporary list 
                    packHalf.Add(pack[Pack_Pointer]); //Adds the card in relation to the pack pointer to the temporary list
                    packHalf.Add(pack[Pack_Pointer + (pack.Count/2)]); // this adds the pack pointer to half the pack to retrieve the card that should be added
                    Pack_Pointer++; // Adds one to the pack pointer after adding the two cards to the list
                }
                pack = packHalf; // sets the value of the pack to the temporary list
                return true;
            }
            // This code checks if the value passed is 3 and if it is doesnt shuffle the cards
            else if (typeOfShuffle == 3)
            {
                Console.WriteLine("You have selected that the pack is not to be shuffled therefore there is no change to the pack"); // This will write to the console that the pack hasnt been shuffled
                return true;
            }
            else
            {
                return false; // if there is any integer passed through other than the three corresponding to the shuffles it will return false
            }
        }
        // This method will deal one card
        public static Card Deal()
        {
            if (pack.Count == 0) // checks if the pack has been built
            {
                Console.WriteLine("The pack is empty"); // if the pack is empty will write to the console that the pack is empty
                return null; // indicates nothing has been reurned and ends
            }
            else
            {
                Card FirstCard = pack[0]; // Defines Firstcard as the first item in the pack
                pack.RemoveAt(0); // Will remove the first item in the pack
                return FirstCard; // returns the first item in the pack
                

            }

        }
        // This method deals an amount of cards passed through
        public static List<Card> DealCard(int amount) 
        {
            if (pack.Count == 0) // checks if the pack has been built
            {
                Console.WriteLine("The pack is empty"); // if the pack is empty will write to the console that the pack is empty
                return null; // indicates nothing has been returned 
            }
            else if (pack.Count < amount) // Checks if there is enough cards left in the pack to deal this amount
            {
                Console.WriteLine("There is not enough cards left in the pack to deal this amount"); // outputs that there isnt enough cards left in the pack to deal the amount specified
                return null; // indicates nothing has been returned and ends
            }
            else
            {
                int packPointer = 1; // defines the pack pointer as 1
                while (packPointer <= amount) // while the pack pointer is less than or equal to the amount of cards needed to be returned
                {
                    Card FirstCard = pack[0]; //Defines FirstCard as the first item in the pack
                    pack.RemoveAt(0); // Removes the first item in the pack
                    packPointer++; // Adds one to the pack pointer and continues through the while loop until it is less than or equal to the amount
                    dealtCards.Add(FirstCard); // Adds the first card in the pack to a list which holds all cards that have been dealt
                }
                return dealtCards; // returns the list that holds all the dealt cards so far
            }

        }
        public static void DisplayPack() // This method displays the pack
        {
            foreach (Card card in pack)
            {
                card.Show(); // This calls the Show function in the Card file

            }
        }
    }
}
 