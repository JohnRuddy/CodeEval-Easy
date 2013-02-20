using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReverseWords
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

                    ReverseLineWords(line);
                }

            Console.Read();
        }

        private static void ReverseLineWords(string line)
        {
            if (line.Trim().Length > 1)
            {
                var reversed = (from words in line.Split(' ').ToArray()
                                select words).Reverse();

                var output = string.Empty;

                var lastIndex = reversed.Count() - 1;
                var indexCount = 0;
                foreach (var item in reversed)
                {
                    Console.Write(string.Format("{0}", item));
                    
                    if (indexCount != lastIndex)
                    {
                        Console.Write(" ");
                    }
                    indexCount++;
                }

                Console.WriteLine();    
            }
            
        }
    }
}
