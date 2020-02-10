using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOrganAssignment1
{
    class Program
    {
        public static string UsfTime(string s)
        {
            int U1 = (int)s[0] - '0';
            int U2 = (int)s[1] - '0';
            int S1 = (int)s[3] - '0';
            int S2 = (int)s[4] - '0';
            int F1 = (int)s[6] - '0';
            int F2 = (int)s[7] - '0';
            int UU = (U1 * 10 + U2 % 10);
            int SS = (S1 * 10 + S2 % 10);
            int FF = (F1 * 10 + F2 % 10);

            if (s[8] == 'A')
            {
                int uCounter = 0;
                int sCounter = 0;
                int fCounter = 0;
                int totalCount;
                int timeChange = ((UU * 3600) + (SS * 60) + FF);
                for (totalCount = 1; totalCount <= timeChange; totalCount++)
                {
                    if (fCounter <= 44)
                    {
                        fCounter++;
                    }
                    if (fCounter > 44)
                    {
                        sCounter++;
                        fCounter = 0;
                    }
                }
                Console.Write(uCounter + ":" + sCounter + ":" + fCounter);
            }
            else
            {
                UU = UU + 12;
                int uCounter = 0;
                int sCounter = 0;
                int fCounter = 0;
                int totalCount;
                int timeChange = ((UU * 3600) + SS * 60) + FF;
                for (totalCount = 0; totalCount < timeChange; totalCount++)
                {
                    if (fCounter <= 44)
                    {
                        fCounter++;
                    }
                    if (fCounter > 44)
                    {
                        sCounter++;
                        fCounter = 0;
                    }
                    if (sCounter > 59)
                    {
                        uCounter++;
                        sCounter = 0;
                    }
                }
                Console.WriteLine(uCounter + ":" + sCounter + ":" + fCounter);
            }
            return s;
        }
        public static void Main(string[] args)
        {
            string s = "09:15:35PM";
            Console.WriteLine(s);
            string t = UsfTime(s);
            Console.ReadLine();
        }
    }
}