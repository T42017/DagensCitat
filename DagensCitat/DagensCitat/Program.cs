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
            //Glöm ej att skapa en branch "feature-förnamn" INNAN du gör ändringar i koden :)
            string currentDirName = System.IO.Directory.GetCurrentDirectory();
            List<string> quotes = System.IO.File.ReadAllLines(currentDirName+ @"\citat.txt").ToList();
            int dayOfYear = int.Parse(DateTime.Today.DayOfYear.ToString());
            int quoteChecker = dayOfYear % quotes.Count;
            Console.WriteLine("Quote of the day is: " + quotes[quoteChecker]);
            Console.ReadLine();



        }
    }
}
