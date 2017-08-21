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
        private static DelayableQueue<string> _quotes = new DelayableQueue<string>(File.ReadAllLines(_filePath));
        private static TimeSpan _timeOfDayToStart = TimeSpan.Parse("13:56");
        private static TimeSpan _timeOfDayToEnd = TimeSpan.Parse("13:58");

        static void Main(string[] args)
        {
            while (true)
            {
                var quote = _quotes.DequeueAndEnqueueWithDelay(TimeSpan.FromMilliseconds(250));
                Console.WriteLine(quote);
            }
        }
    }
}
