using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DagensCitat
{
    public class DelayableQueue<T>
    {
        private List<T> _items;

        public DelayableQueue()
        {
            _items = new List<T>();
        }

        public DelayableQueue(T[] input) : this()
        {
            foreach (T inputItem in input)
            {
                _items.Add(inputItem);
            }
        }

        public void Enqueue(T item)
        {
            _items.Add(item);
        }

        public T Dequeue()
        {
            return DequeueAndEnqueueWithDelay(TimeSpan.Zero);
        }

        /// <summary>
        /// Returns the first element in the queue, then enqueues it at the end - finally sleeps for delayTime amount of time.
        /// </summary>
        /// <param name="delayTime"></param>
        /// <returns></returns>
        public T DequeueAndEnqueueWithDelay(TimeSpan delayTime)
        {
            if (_items.Count == 0)
            {
                throw new NullReferenceException();
            }

            Thread.Sleep(delayTime);

            T firstItem = _items[0];
            _items.RemoveAt(0);
            _items.Add(firstItem);
            return firstItem;
        }


        #region TODO
        public T DequeueAndEnqueueWithDelay(TimeSpan timeToStart, TimeSpan timeToEnd, TimeSpan delayTime)
        {
            int currentMinutes = (int)DateTime.Now.TimeOfDay.TotalMinutes;
            int startMinutes = (int)timeToStart.TotalMinutes;
            int endMinutes = (int)timeToEnd.TotalMinutes;

            while (currentMinutes < startMinutes && currentMinutes > endMinutes)
            {
                Thread.Sleep(1000);
            }
            return DequeueAndEnqueueWithDelay(delayTime);
        }

        //public T DequeueAndEnqueueWithDelay(TimeSpan timeToStart)
        //{
        //    if ((int)DateTime.Now.TimeOfDay.TotalMinutes == (int)timeToStart.TotalMinutes)
        //    {
        //        Thread.Sleep(TimeSpan.FromSeconds(5));
        //        T firstItem = _items[0];
        //        _items.RemoveAt(0);
        //        _items.Add(firstItem);
        //        return firstItem;
        //    }
        //}
        #endregion
    }
}
