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
            List<string> quotes = new List<string>();

            string path = @"C:\Git\DagensCitat-Uppgift\DagensCitat\DagensCitat\DagensCitat\Citat.txt";
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {

                    while (sr.Peek() >= 0)
                    {
                        quotes.Add(sr.ReadLine());
                    }
                }
            }

            int day = DateTime.Today.DayOfYear;            
            int quoteIndex = day % quotes.Count; 
            
            Console.WriteLine(quotes[quoteIndex]);
            Console.ReadKey();

        }
    }
}