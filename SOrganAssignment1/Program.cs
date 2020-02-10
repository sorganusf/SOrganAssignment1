using System;

namespace SOrganAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here I have initiated the for loop that will
            //be the main basis of each number being created
            //up until number 110.
            for (int number = 1; number <= 110; ++number)
            {
                //I need to establish a boolean variable here.
                bool remainder = false;

                //This is the beginning of the if-else-if statements.
                //I start with if the number is divisble by 3, 5, and 7, making
                //a new label for that number as USF.
                if (number % 3 == 0 && number % 5 == 0 && number % 7 == 0)
                {
                    Console.Write("USF");
                    remainder = true;
                }
                //If the number is divisible by 3 and 5 it will now be US.
                else if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.Write("US");
                    remainder = true;
                }
                //If the number is divisible by 3 and 7 it will now be SF.
                else if (number % 5 == 0 && number % 7 == 0)
                {
                    Console.Write("SF");
                    remainder = true;
                }
                //If the number is only divisible by 3 it will be U.
                else if (number % 3 == 0)
                {
                    Console.Write("U");
                    remainder = true;
                }
                //If the number is only divisible by 7 it will be F.
                else if (number % 7 == 0)
                {
                    Console.Write("F");
                    remainder = true;
                }
                //If the number is only divisible by 5 it will be S.
                else if (number % 5 == 0)
                {
                    Console.Write("S");
                    remainder = true;
                }
                //If the number is not divisible by any it will print the number.
                if (!remainder)
                {
                    Console.Write(number);
                }
                //If the number is divisible by 10 it will establish a new line.
                Console.Write(" ");
                if (number % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
