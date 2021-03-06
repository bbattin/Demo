﻿using System;
//using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180328_GenericDemoBoxUnbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(10);
            s.Push(100);
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());


            // ContainerDemo();

            Console.ReadKey();
        }

        private static void ContainerDemo()
        {
            Container c = new Container(10);

            c.Add(2);
            c.Add(5);
            c.Add(-5);
            c.Add(8);

            PrintContainer2(c);

            c.Add(2.01);

            PrintContainer2(c);
        }

        // with unbpoxing
        private static void PrintContainer1(Container c)
        {
            for (int i = 0; i < c.Count; i++)
            {
                int item = (int)c[i];
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();
        }

        // without unbpoxing
        private static void PrintContainer2(Container c)
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
