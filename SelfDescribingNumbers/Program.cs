using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SelfDescribingNumbers
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

                    CheckIsSelfDescribingNumber(line);
                }

            Console.Read();
        }

        private static void CheckIsSelfDescribingNumber(string number)
        {
            
            Dictionary<string, int> lookup = new Dictionary<string, int>();

            for (int i = 0; i < number.Length; i++)
            {
                if (!lookup.Keys.Contains("" + number[i]))
                {
                    lookup.Add("" + number[i], 1);
                }
                else
                {
                    lookup["" + number[i]]++;
                }
            }

            var isSelfDescribing = 0;

            isSelfDescribing = CheckSelfDescription(number, lookup, isSelfDescribing);

            Console.WriteLine(isSelfDescribing);
        }

        private static int CheckSelfDescription(string number, Dictionary<string, int> lookup, int isSelfDescribing)
        {
            for (int i = 0; i < number.Length; i++)
            {
                var valueAtPosition = number[i];
                if (lookup.ContainsKey("" + i))
                {
                    var countOfNumberInArray = lookup["" + i];
                    //does value at position 
                    if (int.Parse("" + valueAtPosition) == countOfNumberInArray)
                    {
                        isSelfDescribing = 1;
                    }
                    else
                    {
                        isSelfDescribing = 0;
                    }
                }
            }
            return isSelfDescribing;
        }
    }
}
