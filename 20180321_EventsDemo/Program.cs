using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180321_EventsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publ = new Publisher();

            publ.Iteration += OnNextIter;

            publ.Run();

            Subscriber suscr = new Subscriber(publ);

            publ.Run();

            Console.ReadKey();
        }

        // статический слушатель
        public static void OnNextIter(object sender, NextIterationEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("args.Iter = {0}", args.Iter);
        }
    }
}
