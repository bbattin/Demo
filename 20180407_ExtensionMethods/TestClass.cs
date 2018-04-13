using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180407_ExtensionMethods
{
    class TestClass
    {
        public void f1()
        {
            Console.WriteLine("TestClass.f1()");
        }

        public void f2()
        {
            Console.WriteLine("TestClass.f2()");
        }

        public void f1(int a)
        {
            Console.WriteLine("TestClass.f1({0})", a);
        }

        public void f2(double b)
        {
            Console.WriteLine("TestClass.f2({0})", b);
        }
    }
}
