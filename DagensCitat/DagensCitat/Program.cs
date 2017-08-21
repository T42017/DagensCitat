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
            List<string> quotes = new List<string>();
            for (int i = 0; i < 365; i++)
            {
                quotes.Add("Inspirational quote #" + i);
            }

            int day = DateTime.Today.DayOfYear;
            string quoteToSay;

            while(day > quotes.Count)
            {
                day -= quotes.Count;
            }
   
            quoteToSay = quotes[day];
                   
            Console.WriteLine(quoteToSay);
            Console.ReadKey();

        }
    }
}