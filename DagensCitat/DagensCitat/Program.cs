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
            quotes.Add("You can't blame gravity for falling in love ");
            quotes.Add("Love has no age, no limit; and no death ");
            quotes.Add("Love isn't something you find. Love is something that finds you ");
            quotes.Add("Tell me and I forget. Teach me and I remember. Involve me and I learn ");
            quotes.Add("Don't walk behind me; I may not lead. Don't walk in front of me; I may not follow. Just walk beside me and be my friend ");
            quotes.Add("One of the most beautiful qualities of true friendship is to understand and to be understood ");
            quotes.Add("Do not dwell in the past, do not dream of the future, concentrate the mind on the present moment ");
            quotes.Add("Friends show their love in times of trouble, not in happiness ");
            quotes.Add("As we express our gratitude, we must never forget that the highest appreciation is not to utter words, but to live by them ");
            quotes.Add("Success is not final, failure is not fatal: it is the courage to continue that counts ");
            quotes.Add("The best and most beautiful things in the world cannot be seen or even touched - they must be felt with the heart ");

            //Glöm ej att skapa en branch "feature-förnamn" INNAN du gör ändringar i koden :)
            //for (int i = 0; i < 365; i++)
            //{
            //    quotes.Add("Quote" + i);
            //}
            string day = DateTime.Today.DayOfWeek.ToString();
            int dayOfYear = int.Parse(DateTime.Today.DayOfYear.ToString());

            Console.WriteLine(dayOfYear);
            Console.WriteLine("Quote of the day is: " + quotes[dayOfYear % quotes.Count]);
            Console.ReadLine();
            

        }
    }
}
