using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180207_PolymorphismDemo
{
    class B : A
    {
        public void f2()
        {
            Console.WriteLine("A.f2()");
        }

        public new void f1()
        {
            Console.WriteLine("B.f1()");
        }

        // f3() - виртуальный метод, который переопределяется
        //public new virtual void f3()
        public override void f3()
        {
            Console.WriteLine("B.f3()");
        }

        public override void f4()
        {
            Console.WriteLine("B.f4()");
        }
    }
}
