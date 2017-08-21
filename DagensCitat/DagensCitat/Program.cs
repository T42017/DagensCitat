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
            List<string> citatLista = System.IO.File.ReadLines(@"C:\GIT\DagensCitat\DagensCitat\DagensCitat\citatLista.Txt").ToList();
            
            int dayOfYear = int.Parse(DateTime.Today.DayOfYear.ToString());
            int quoteFromList = dayOfYear % 8;

            Console.WriteLine(citatLista[quoteFromList]);

            Console.ReadLine();

        }
    }
}
