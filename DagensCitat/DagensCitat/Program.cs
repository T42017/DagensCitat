using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DagensCitat
{
    class Program
    {
        static void Main(string[] args)
        {
            var quotesList = new List<string>(File.ReadLines("quotes.txt"));
            var timeSinceBeginning = DateTime.Now - DateTime.MinValue;
            Console.WriteLine(quotesList[timeSinceBeginning.Days % quotesList.Count]);
            Console.ReadKey();
        }
    }
}
