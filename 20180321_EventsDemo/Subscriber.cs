using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180321_EventsDemo
{
    class Subscriber
    {
        public Subscriber(Publisher p)
        {
            p.Iteration += OnNextIter1;
            p.Iteration += OnNextIter2;
        }

        public void OnNextIter1(object sender, NextIterationEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Subscriber.OnNextIter1(): args.Iter = {0}", args.Iter);
        }

        public void OnNextIter2(object sender, NextIterationEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Subscriber.OnNextIter2(): args.Iter = {0}", args.Iter);
        }
    }
}
