using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace DagensCitat
{
    class Program
    {
        static readonly string FilePath = (Environment.CurrentDirectory + @"\..\..\Properties\txt_daily.txt");
        static DelayOfQuotes<string> _quotes = new DelayOfQuotes<string>(File.ReadAllLines(FilePath));


        static void Main(string[] args)
        {
            while (true)
            {
                var quote = _quotes.EnqueueTheDequeue(TimeSpan.FromHours(24));
                Console.WriteLine(quote);
            }
        }
    }
}
