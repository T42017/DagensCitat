using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DagensCitat
{
    class Program
    {
        private static readonly DateTime StartDate = new DateTime(2017, 8, 21);

        static void Main(string[] args)
        {
            List<String> quates = new List<String>();
            quates.Add("I love you the more in that I believe you had liked me for my own sake and for nothing else. John Keats");
            quates.Add("But man is not made for defeat. A man can be destroyed but not defeated. Ernest Hemingway");
            quates.Add("When you reach the end of your rope, tie a knot in it and hang on. Franklin D.Roosevelt");
            quates.Add("There is nothing permanent except change. Heraclitus");

            DateTime thisDate = DateTime.Now;
            int daysFromStartDate = (int) (thisDate - StartDate).TotalDays;
            String quate = quates.ElementAt(daysFromStartDate % quates.Count);
            Console.WriteLine(quate);
            Console.ReadLine();
        }
    }
}
