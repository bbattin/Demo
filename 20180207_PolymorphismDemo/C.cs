using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180207_PolymorphismDemo
{
    class C : B
    {
        // порождение новой цепочки виртуальных методов
        public new virtual void f3()
        //public override void f3()
        {
            Console.WriteLine("C.f3()");
        }

        public sealed override void f4()
        {
            base.f4();
            base.f3();
            Console.WriteLine("C.f4()");
        }
    }
}
