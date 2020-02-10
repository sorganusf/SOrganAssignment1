using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOrganAssignment1
{
    class Program
    {
        public static void PalindromePairs(string[] words)
        {
            string checkWords = "";
            string wordsReverse = "";
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    checkWords = words[i] + words[j];
                    checkWords.Reverse();
                    wordsReverse = words[j] + words[i];
                }
            }
            Console.Write("The palindromes are " + checkWords);
        }
        public static void Main(string[] args)
        {
            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);
            Console.ReadLine();
        }
    }
}