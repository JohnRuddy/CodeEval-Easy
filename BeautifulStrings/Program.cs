using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BeautifulStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();


                    if (null == line)
                        continue;
                    // do something with line

                    CalculateBeautifulStringValue(line);
                }

            Console.Read();
        }

        private static void CalculateBeautifulStringValue(string somestring)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();


            var myString = somestring.ToLower().Replace(" ", "");

            var letterList = from l in myString
                             where l <= 'z' && l >= 'a'
                             select l;

            foreach (var letter in letterList)
            {
                if (!letters.ContainsKey(letter))
                {
                    letters.Add(letter, 1);
                }
                else
                {
                    letters[letter] = letters[letter] + 1;
                }
            }

            // calculate the score
            int max_score = 26;
            int sum = 0;

            var lettersSorted = letters.OrderByDescending(x => x.Value);

            foreach (var item in lettersSorted)
            {
                sum = sum + (item.Value * max_score);
                max_score = max_score - 1;
            }

            Console.WriteLine(sum);
        }
    }
}
