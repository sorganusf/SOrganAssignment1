using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOrganAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here we ask the user to input how many stones they would
            //like to have be put into the bag.
            Console.Write("Input how many stones are in the bag: ");
            string input = Console.ReadLine();
            int numberOfStones = Convert.ToInt32(input);
            
            //I created an if-else statement depending on how many stones the user
            //would like added to the bag.
            //If the user picks any number that is divisble by 4, they immediately lose
            //the game because Player 2 will always have an advantage in those situations.
            if (numberOfStones % 4 == 0)
            {
                Console.WriteLine("false");
                //I am explaining to Player 1 that they have lost because they selected
                //4 stones to be put in the bag. This means no matter how many stones they
                //grab first, Player 2 will end up winning the game.
                Console.WriteLine("Explanation: As there are 4 stones" +
                    " in the bag, you will never win the game.");
                Console.WriteLine("No matter 1, 2, or 3 stones you take out," +
                    " the last stone will always be removed by your friend.");
            }
            else
            {
                //Here I am explaining that Player 1 will win since they do not have to
                //worry about the number of stones being divisble by the number 4.
                Console.WriteLine("Player 1 wins!");
                Console.WriteLine("Player 1 will always win as long as they take the correct amount" +
                    "of stones to prevent Player 2 from winning");
            }

            Console.ReadLine();
        }
    }
}
