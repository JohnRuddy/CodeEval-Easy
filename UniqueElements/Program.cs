using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace UniqueElements
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
                SortAndDisplayInput(line);
            }
            Console.Read();
        }

        private static void SortAndDisplayInput(string line)
        {
            var arr = line.Split(',').ToArray();
            // int[] arr = { 1, 1, 1, 2, 2, 3, 3, 4, 4 };

            var sorted = from a in arr
                         orderby a
                         select int.Parse(a);

            var distinct = sorted.Distinct<int>();
            var outputString = string.Empty;
            foreach (var item in distinct)
            {
                outputString = outputString + item;
                if (!distinct.Last<int>().Equals(item))
                {
                    outputString = outputString + ",";
                }
            }

            Console.WriteLine(outputString);
        }
    }
}
