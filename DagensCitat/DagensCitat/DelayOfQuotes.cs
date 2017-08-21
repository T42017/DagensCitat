using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DagensCitat
{
    class DelayOfQuotes<Temp>
    {
        private readonly List<Temp> _quotes;

        public DelayOfQuotes()
        {
            _quotes = new List<Temp>();

        }

        public DelayOfQuotes(Temp[] input) : this()
        {
            foreach (var inputItem in input)
            {
                _quotes.Add(inputItem);
            }
        }

        public void Enqueue(Temp quote)
        {
            _quotes.Add(quote);
        }

        public Temp Dequeue()
        {
            return EnqueueTheDequeue(TimeSpan.Zero);
        }

        public Temp EnqueueTheDequeue(TimeSpan delayTime)
        {
            if (_quotes.Count == 0)
            {
                throw new NullReferenceException();
            }

            Thread.Sleep(delayTime);

            var firstQuote = _quotes[0];
            _quotes.RemoveAt(0);
            _quotes.Add(firstQuote);
            return firstQuote;
        }

    }
}
