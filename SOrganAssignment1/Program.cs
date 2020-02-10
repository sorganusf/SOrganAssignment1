using System;

namespace SOrganAssignment1
{
    class Program
    {
        public static string UsfTime(string s)
        {
            //I needed to establish all variables here.
            //These variables included all numbers input
            //from Earth time.
            int U1 = (int)s[0] - '0';
            int U2 = (int)s[1] - '0';
            int S1 = (int)s[3] - '0';
            int S2 = (int)s[4] - '0';
            int F1 = (int)s[6] - '0';
            int F2 = (int)s[7] - '0';
            int UU = (U1 * 10 + U2 % 10);
            int SS = (S1 * 10 + S2 % 10);
            int FF = (F1 * 10 + F2 % 10);

            //I created a simple if-else statement to have the program
            //respond to the time depending on if AM or PM time is on the clock.
            if (s[8] == 'A')
            {
                //I needed to establish counter variables here to accumulate
                //for U (hours), S (minutes), and F (seconds). A total count
                //for all minutes was also created.
                int uCounter = 0;
                int sCounter = 0;
                int fCounter = 0;
                int totalCount;
                //The timeChange variable ties together with totalCount.
                //timeChange is the equation used to find out how many total
                //minutes there will be.
                int timeChange = ((UU * 3600) + (SS * 60) + FF);
                //I made a for loop for each portion of the if-else statement
                //where the counters will continue to loop and accumulate
                //until the totalCount matches the seconds in timeChange.
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
                Console.Write(uCounter + ":" + sCounter + ":" + fCounter);
            }
            //Here is the second section of if-else. This is for PM time.
            //UU adds 12 before the timeChange equation, indicating that
            //PM time is 12 hours later.
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
                //Here I show the final counter totals from the equation that
                //will become the new USF time after converting.
                Console.WriteLine(uCounter + ":" + sCounter + ":" + fCounter);
            }
            return s;
        }
        public static void Main(string[] args)
        {
            //Here is the original string and new string (t) that calls
            //the UsfTime conversion method.
            string s = "09:15:35PM";
            Console.WriteLine(s);
            string t = UsfTime(s);
            Console.ReadLine();
        }
    }
}
