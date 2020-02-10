using System;

namespace SOrganAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here I created nested for loops for each of the numbers.
            //As each loop finishes, a number is subtracted off the next line.
            for (int z = 5; z >= 1; z--)
            {
                //The nested loop is important in lessening each row by 1 number.
                //54321 becomes 4321, then 321, etc.
                for (int x = z; x > 0; x--)
                {
                    //I am printing each line as they progress through the loops.
                    Console.Write(x);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
