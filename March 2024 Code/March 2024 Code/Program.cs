using System;
namespace March_2024_Code
{
    internal class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello worldy");
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

        /* Keeping Count
            Given a number, create a function which returns a new number based on the following rules:

            For each digit, replace it by the number of times it appears in the number.
            The final instance of the number will be an integer, not a string.
            The following is a working example:

            DigitCount(136116) ➞ 312332
            // The number 1 appears thrice, so replace all 1s with 3s.
            // The number 3 appears only once, so replace all 3s with 1s.
            // The number 6 appears twice, so replace all 6s with 2s.
            
            Examples:
            DigitCount(221333) ➞ 221333

            DigitCount(136116) ➞ 312332

            DigitCount(2) ➞ 1

            Notes:
            Each test will have a positive whole number in its parameter.
         
         */

        public static long DigitCount(long num)
        {
            string word = num.ToString();
            Dictionary<long, long> dic = new Dictionary<long, long>();
            Stack<long> foo = new Stack<long>();
            foreach (var i in word)
            {
                long temp = long.Parse(i.ToString());
                foo.Push(temp);
                if (dic.ContainsKey(temp))
                {
                    dic[temp] += 1;
                }
                else
                {
                    dic.Add(temp, 1);
                }
            }
            int tick = word.Length - 1;
            long mul = 10;
            long final = dic[foo.Pop()];
            while (tick > 0)
            {
                final += mul * dic[foo.Pop()];
                mul *= 10;
                tick--;
            }
            return final;
        }

    }
}