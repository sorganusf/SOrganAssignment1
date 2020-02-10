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
            for (int z = 5; z >= 1; z--)
            {
                for (int x = z; x > 0; x--)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}