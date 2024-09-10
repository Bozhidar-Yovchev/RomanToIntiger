using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a roman numeral:");
            string roman = Console.ReadLine().ToUpper();
            Dictionary<string, int> dict =
            new Dictionary<string, int>();
            AddToDictionary(dict);


            int result = RomanToInteger(roman, dict);
            Console.WriteLine($"The integer value of {roman} is: {result}");

        }

        private static void AddToDictionary(Dictionary<string, int> dict)
        {
            dict.Add("I", 1);
            dict.Add("V", 5);
            dict.Add("X", 10);
            dict.Add("L", 50);
            dict.Add("C", 100);
            dict.Add("D", 500);
            dict.Add("M", 1000);
            dict.Add("IV", 4);
            dict.Add("IX", 9);
            dict.Add("XL", 40);
            dict.Add("XC", 90);
            dict.Add("CD", 400);
            dict.Add("CM", 900);
        }
        private static int RomanToInteger(string roman, Dictionary<string, int> dict)
        {
            int sum = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && dict.ContainsKey(roman.Substring(i, 2)))
                {
                    sum += dict[roman.Substring(i, 2)];
                    i++; 
                }
                else
                {
                    sum += dict[roman.Substring(i, 1)];
                }
            }
            return sum;
        }
    }
}
