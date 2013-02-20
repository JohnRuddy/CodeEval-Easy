using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RightmostChar
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
                    CalculateRightMostChar(line);
                }
            Console.Read();
        }

        private static void CalculateRightMostChar(string line)
        {
            var args = line.Split(',');

            var stringToSearch = args[0].ToCharArray();
            var characterToFind = char.Parse(args[1]);
            var rightMostPosition = -1;

            for (int i = 0; i < stringToSearch.Length;  i++)
            {
                if (characterToFind.Equals(stringToSearch[i]))
                {
                    rightMostPosition = i;
                }
            }
            Console.WriteLine(rightMostPosition);
        }
    }
}
