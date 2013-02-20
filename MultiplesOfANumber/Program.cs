using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MultiplesOfANumber
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

                    Console.WriteLine(MultiplesOfANumber(line));
                }
            Console.Read();
        }

        protected static string MultiplesOfANumber(string input)
        {
            var inputs = input.Split(',');
            var x = int.Parse(inputs[0]);
            var n = int.Parse(inputs[1]);

            var i = 0;
            var result = 0;

            while (true)
            {
                if (result > x)
                {
                    break;    
                }
                result = n * i;
                i++;
            }

            return "" + result;
   
        }
    }
}
