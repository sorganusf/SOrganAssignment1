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
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);

            int answer = 0;

            for (int i = 1; i <= n; i++)
            {
                answer = i * (i + 1) / 2;

                Console.Write(answer + ", ");
            }
        }
    }
}