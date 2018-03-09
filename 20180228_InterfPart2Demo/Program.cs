using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180228_InterfPart2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            ImplI1I2 obj = new ImplI1I2();

            obj.f1();            

            TestI1(obj);

            TestI2(obj);

            Console.ReadKey();
        }

        private static void TestI1(I1 i)
        {
            i.f1();
        }

        private static void TestI2(I2 i)
        {
            i.f1();
        }
    }
}
