using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DagensCitat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> quotes = System.IO.File.ReadAllLines(@"C:\Users\usr\Documents\Git repositories\DagensCitat\DagensCitat\DagensCitat\citat.txt").ToList();
           

            //Glöm ej att skapa en branch "feature-förnamn" INNAN du gör ändringar i koden :)
            
            string day = DateTime.Today.DayOfWeek.ToString();
            int dayOfYear = int.Parse(DateTime.Today.DayOfYear.ToString());

            Console.WriteLine(dayOfYear);
            Console.WriteLine("Quote of the day is: " + quotes[dayOfYear % quotes.Count]);
            Console.ReadLine();
            

        }
    }
}
