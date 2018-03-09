using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180307_OpOverloadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyInt n1 = new MyInt(10);
            MyInt n2 = new MyInt(20);

            bool n1LessThanN2 = n1 <= n2;
            
            MyInt n3 = MyInt.Plus(n1, n2);

            MyInt n4 = n1 + n2;

            Console.WriteLine("n3 = {0}", n3);
            Console.WriteLine("n4 = {0}", n4);

            MyInt n5 = n1 + 22;

            MyInt n6 = n2--;
            Console.WriteLine("n2 = {0}", n2);
            Console.WriteLine("n6 = {0}", n6);

            MyInt n7 = ++n5;
            Console.WriteLine("n5 = {0}", n5);
            Console.WriteLine("n7 = {0}", n7);


            Console.ReadKey();
        }
    }
}
