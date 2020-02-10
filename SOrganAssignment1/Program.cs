using System;

namespace SOrganAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here I ask the user to enter a number.
            //n will be the converted integer from the input.
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);

            //Establishing answer variable.
            int answer = 0;

            //Created for loop for each new number that
            //will be created.
            for (int i = 1; i <= n; i++)
            {
                //Answer becomes new number
                answer = i * (i + 1) / 2;

                //Number is printed each time through, being
                //added on from the previous number in the cycle.
                Console.Write(answer + ", ");
            }
            Console.ReadLine();
        }
    }
}
