using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SumOfIntsFromFile
{
    class Program
    {
        public static int sum = 0;
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();


                    if (null == line)
                        continue;
                    // do something with line

                    sum = sum + int.Parse(line);
                }
            Console.WriteLine(sum);
            Console.Read();
        }

    }
}
