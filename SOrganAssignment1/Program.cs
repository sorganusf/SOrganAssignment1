using System;

namespace SOrganAssignment1
{
    class Program
    {
        public static void PalindromePairs(string[] words)
        {
            //We need to introduce two strings here. One string is
            //used for the pairing of i first and then j, the second is for pairing
            //j first, then i.
            string checkWords = "";
            string wordsReverse = "";

            //I created a nested loop here for each of the spots in the array.
            //The loops will manuever through each set of letters.
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    //I introduce the strings in the inner loop
                    //so append each set of letters together.
                    checkWords = words[i] + words[j];
                    wordsReverse = words[j] + words[i];

                    //I will compare the two strings together and determine
                    //which sets will form palindromes.
                }
            }
            //Here I am writing out which sets are palindromes from the strings.
            Console.Write("The palindromes are " + checkWords);
        }
        public static void Main(string[] args)
        {
            //The main method here introduces the words string and calls the Palindrome
            //Pairs method, which will reveal which letters appeneded together create
            //palindromes.
            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);
            Console.ReadLine();
        }
    }
}
