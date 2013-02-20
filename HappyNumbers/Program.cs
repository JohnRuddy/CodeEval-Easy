using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HappyNumbers
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
                    Console.WriteLine(GenerateHappyNumber(int.Parse(line)));
                }
            Console.Read();
        }

        private static int GenerateHappyNumber(int p)
        {
            // square number
            int count = 0;
            while (count <= 1000)
            {
                p = SquareOfDigits(p);
                if (p == 1)
                {
                    return 1;
                }
                count ++;
            }
            return 0;
            
        }

        private static int SquareOfDigits(int p)
        {
            var arr = "" + p;
            var sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + (int.Parse("" + arr[i]) * int.Parse("" + arr[i]));
            }

            return sum;
        }



    }
}
