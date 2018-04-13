using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180411_GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Container<int> c = new Container<int>(100);

            c.Add(2);
            c.Add(5);
            c.Add(-5);
            c.Add(8);
            c.Add(9);

            PrintContainer2(c);

            // c.Add(2.01);    // !!! контроль типов при работе с экземплярами обобщенного класса !!!

            PrintContainer2(c);

            

            Console.ForegroundColor = ConsoleColor.Green;
            //foreach (var item in c.Reverse())
            //{
            //    if (item == null)
            //    {
            //        Console.Write("_ ");
            //    }
            //    else
            //    {
            //        Console.Write("{0} ", item);
            //    }
            //}
            //Console.WriteLine();

            Container<double> c1 = new Container<double>(100);

            c1.Add(2);
            c1.Add(5);
            c1.Add(-5);
            c1.Add(8);
            c1.Add(9);

            PrintContainer1(c1);

            c1.Add(2.01);    // !!! контроль типов при работе с экземплярами обобщенного класса !!!

            PrintContainer1(c1);

            IEnumerable iter1 = c1;

            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var item in iter1)
            {
                if (item == null)
                {
                    Console.Write("_ ");
                }
                else
                {
                    Console.Write("{0} ", item);
                }
            }
            Console.WriteLine();


            IEnumerable<double> iter2 = c1;

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in iter2)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Console.ReadKey();
        }

        // without unbpoxing
        private static void PrintContainer1<T>(IContainer<T> c)
        {
            for (int i = 0; i < c.Count; i++)
            {
                Console.Write("{0}\t", c[i]);
            }
            Console.WriteLine();
        }

        // without unbpoxing
        private static void PrintContainer2(IContainer<int> c)
        {
            for (int i = 0; i < c.Count; i++)
            {
                //string item = (string)c[i];
                string item = c[i].ToString();

                int number = int.Parse(item);

                Console.Write("{0}\t", number);

                //Console.Write("{0}\t", c[i]);
            }
            Console.WriteLine();
        }
    }
}
