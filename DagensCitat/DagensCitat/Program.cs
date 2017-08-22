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

            List<string> quoteList = new List<string>();
            quoteList.Add("1");
            quoteList.Add("2");
            quoteList.Add("3");
            quoteList.Add("4");
            quoteList.Add("5");
            quoteList.Add("6");
            quoteList.Add("7");
            quoteList.Add("8");
            quoteList.Add("9");
            quoteList.Add("10");





            int numberOfQuotes = quoteList.Count;

            DateTime dateThen = new DateTime(2017, 08, 22, 00, 00, 00);
            DateTime dateNow = DateTime.Now;
            double time = dateNow.Subtract(dateThen).TotalDays;

            while (time > numberOfQuotes)
            {
                dateThen = dateThen.AddDays(numberOfQuotes);
                time = dateNow.Subtract(dateThen).TotalDays;
            }

            Console.WriteLine(quoteList[Convert.ToInt32(time)]);

        }
    }
}
