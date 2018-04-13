using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180407_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass t = new TestClass();

            #region Without parameters

            t.f1();
            t.f2();

            Console.ForegroundColor = ConsoleColor.Blue;

            TestUtility.f3(t);

            Console.ForegroundColor = ConsoleColor.Red;

            t.f3();

            #endregion

            Console.WriteLine();
            Console.WriteLine();

            #region With parameters

            Console.ForegroundColor = ConsoleColor.Gray;

            t.f1(2);
            t.f2(3.5);

            Console.ForegroundColor = ConsoleColor.Blue;

            TestUtility.f3(t, 2, 3.5);

            Console.ForegroundColor = ConsoleColor.Red;

            t.f3(2, 3.5);

            #endregion

            Console.WriteLine();
            Console.WriteLine();

            #region Other variants

            int k = 9;

            Console.WriteLine("k = {0}", k);
            Console.WriteLine("k^2 = {0}", k.Sqr());

            double[] d = new double[] { -2.5, 3.3, -5.1, 6.9 };

            Console.WriteLine("d:");
            foreach (var item in d)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            IEnumerable iter = d.MyReverese();
            Console.WriteLine("iter:");
            foreach (var item in iter)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Console.WriteLine("d.MyReverese():");
            foreach (var item in d.MyReverese())
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Console.WriteLine("d.MyReverese():");
            foreach (var item in d.Reverse())
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Console.WriteLine("d.Reverse().MyReverese():");
            foreach (var item in d.Reverse().MyReverese())
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            #endregion


            Console.ReadKey();
        }
    }
}
