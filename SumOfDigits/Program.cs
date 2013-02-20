using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SumOfDigits
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

                    GetSumDigits(line);
                }

            Console.Read();
        }

        private static void GetSumDigits(string line)
        {
            var nums = line.ToCharArray();
            var sum = 0;

            foreach (var item in nums)
            {
                sum = sum + int.Parse("" + item);
            }

            Console.WriteLine(sum);
        }
    }
}
