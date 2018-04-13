using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180407_ExtensionMethods
{
    static class TestUtility
    {
        public static void f3(this TestClass obj)
        {
            obj.f1();
            obj.f2();
        }

        public static void f3(this TestClass obj, int a, double b)
        {
            obj.f1(a);
            obj.f2(b);
        }

        public static int Sqr(this int a)
        {
            return a * a;
        }

        public static IEnumerable MyReverese(this IEnumerable source)
        {
            int size = 0;
            foreach (object item in source)
            {
                ++size;
            }

            object[] destination = new object[size];

            foreach (object item in source)
            {
                destination[--size] = item;
            }

            return destination;
        }
    }
}
