using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180228_InterfPart2Demo
{
    class ImplI1I2 : I1, I2
    {
        public void f1()
        {
            //Console.WriteLine("ImplI1I2.f1()");
            ((I2)this).f1();    // обращение (использование реализации) из интерфейса I2
        }

        void I1.f1()
        {
            Console.WriteLine("I1.f1()");
        }

        void I2.f1()
        {
            Console.WriteLine("I2.f1()");
        }
    }
}
