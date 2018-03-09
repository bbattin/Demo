using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180207_PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            B objB = new C();

            A objAB = objB;    // ссылка на базовый класс может содержать экземпляр произвождного класса

            A objA = new B();

            objAB.f1();
            Console.ForegroundColor = ConsoleColor.Green;
            objAB.f3();
            objAB.f4();
            Console.ForegroundColor = ConsoleColor.White; 

            // is

            if (objAB is B)    // objAB явлается экземпляром класса B
            {

                Console.WriteLine("objAB is B");

                B b = (B)objAB;

                b.f2();
                Console.ForegroundColor = ConsoleColor.Red;
                b.f1();
                Console.ForegroundColor = ConsoleColor.Green;
                b.f3();
                b.f4();
                Console.ForegroundColor = ConsoleColor.White;
            }

            // as
            B b1 = objAB as B;
            if (b1 != null)
            {
                Console.WriteLine("(objAB as B) != null");

                b1 = (B)objAB;

                b1.f2();
            }

            // !!! wrong
            if (objAB is B)    // objAB явлается экземпляром класса B
            {

                Console.WriteLine("objAB is B");

                B b = objAB as B;    // некорректно по производительности !!!

                b.f2();
            }

            Container cont = new Container(100);
            cont.Add(new B());
            cont.Add(new C());
            cont.Add(new B());
            cont.Add(new D());

            Console.ForegroundColor = ConsoleColor.Cyan;
            cont.f4ForAll();


            Console.ReadKey();
        }
    }
}
