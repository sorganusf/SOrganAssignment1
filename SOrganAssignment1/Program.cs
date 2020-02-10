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

            for (int number = 1; number <= 110; ++number)
            {
                bool remainder = false;

                if (number % 3 == 0 && number % 5 == 0 && number % 7 == 0)
                {
                    Console.Write("USF");
                    remainder = true;
                }

                else if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.Write("US");
                    remainder = true;
                }
                else if (number % 5 == 0 && number % 7 == 0)
                {
                    Console.Write("SF");
                    remainder = true;
                }
                else if (number % 3 == 0)
                {
                    Console.Write("U");
                    remainder = true;
                }
                else if (number % 7 == 0)
                {
                    Console.Write("F");
                    remainder = true;
                }
                else if (number % 5 == 0)
                {
                    Console.Write("S");
                    remainder = true;
                }
                if (!remainder)
                {
                    Console.Write(number);
                }
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