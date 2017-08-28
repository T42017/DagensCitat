using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace DagensCitat
{
    class Program
    {
        private static readonly string _filePath = Path.Combine(Environment.CurrentDirectory, @"..\..", @"Resources\quotes.txt");
        private static readonly Queue<string> _quotes = new Queue<string>(File.ReadAllLines((_filePath)));

        private static void Main(string[] args)
        {
            var date = DateTime.Now.Date;

            while (true)
            {
                var today = DateTime.Now.Date;
                if (today <= date) continue;

                Console.Clear();
                date = DateTime.Now.Date;
                var quote = _quotes.Dequeue();
                _quotes.Enqueue(quote);
                Console.WriteLine(quote);
            }
        }
    }
}
