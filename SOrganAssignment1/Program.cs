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

            Console.Write("Input how many stones are in the bag: ");
            string input = Console.ReadLine();
            int numberOfStones = Convert.ToInt32(input);

            if (numberOfStones % 4 == 0)
            {
                Console.WriteLine("false");
                Console.WriteLine("Explanation: As there are 4 stones" +
                    " in the bag, you will never win the game.");
                Console.WriteLine("No matter 1, 2, or 3 stones you take out," +
                    " the last stone will always be removed by your friend.");
            }
            else
            {
                Console.WriteLine("Player 1 wins!");
                Console.WriteLine("Player 1 will always win as long as they take the correct amount" +
                    "of stones to prevent Player 2 from winning");
            }

            Console.ReadLine();
        }
    }
}