using System;
namespace March_2024_Code
{
    internal class EntryPoint
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hello worldy");
            Console.WriteLine("I am adding stuff to this change001");
            Console.WriteLine("Testing merge going to working");

        }

        /* 3/18/2024
            C*ns*r*d Str*ngs Eda- Hard
                Someone has attempted to censor my strings by replacing every vowel with a *, l*k* th*s. 
                Luckily, I've been able to find the vowels that were removed.

                Given a censored string and a string of the censored vowels, 
                return the original uncensored string.

                Example
                uncensor("Wh*r* d*d my v*w*ls g*?", "eeioeo") ➞ "Where did my vowels go?"

                uncensor("abcd", "") ➞ "abcd"

                uncensor("*PP*RC*S*", "UEAE") ➞ "UPPERCASE"

                Notes:
                The vowels are given in the correct order.
                The number of vowels will match the number of * characters in the censored string.
        */

        public static string Uncensor(string txt, string vowels)
        {
            char[] t1 = txt.ToCharArray();
            int x = 0;
            for (int i = 0; i < txt.Length; i++)
            {
                if (t1[i] == '*')
                {
                    t1[i] = vowels[x];
                    x++;
                }
            }
            return String.Join("", t1);
        }
    }
}