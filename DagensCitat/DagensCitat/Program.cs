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
            List<string> quotes = System.IO.File
                .ReadAllLines(@"C:\Git\DagensCitat-Uppgift\DagensCitat\DagensCitat\DagensCitat\Citat.txt").ToList();      

            int day = DateTime.Today.DayOfYear;            
            int quoteIndex = day % quotes.Count; 
            
            Console.WriteLine(quotes[quoteIndex]);
            Console.ReadKey();

        }
    }
}