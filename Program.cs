using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Regex regex = new Regex(@"(=|\/)(?'destination'[A-Z]{1}[A-Za-z]{2,})\1");

            MatchCollection matches = regex.Matches(command);

            int counter = 0;
            List<string> list = new List<string>();

            foreach (Match match in matches)
            {
                list.Add(match.Groups["destination"].Value);

                counter += match.Groups["destination"].Value.Count();
            }

            Console.WriteLine($"Destinations: {string.Join(", ", list)}");
            Console.WriteLine($"Travel Points: {counter}");
        }
    }
}
