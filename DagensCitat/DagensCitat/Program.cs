using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DagensCitat
{
    class Program
    {
        private static string[] quotes = File.ReadAllLines(@"Resources\quotes.txt");

        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            foreach (var quote in quotes)
            {
                builder.Append(quote + "\r\n");
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
