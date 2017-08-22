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
        static void Main(string[] args)
        {
            List<string> citatLista = System.IO.File.ReadLines(@"citatLista.txt").ToList();

            int dayOfYear = int.Parse(DateTime.Today.DayOfYear.ToString());
            int amountOfQuotes = citatLista.Count;
            int quoteFromList = dayOfYear % amountOfQuotes;

            Console.WriteLine(citatLista[quoteFromList]);

            Console.ReadLine();
        }
    }
}
