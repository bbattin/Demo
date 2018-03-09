using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180221_InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            UI.PrintContainer(null);

            IntContainer cont = new IntContainer(4);

            Console.ForegroundColor = ConsoleColor.White;
            UI.PrintContainer(cont);

            DoubleContainer dCont = new DoubleContainer();
            Console.ForegroundColor = ConsoleColor.Green;
            UI.PrintContainer(dCont);

            ChildDoubleContainer dCont1 = new ChildDoubleContainer();
            Console.ForegroundColor = ConsoleColor.Red;
            UI.PrintContainer(dCont1);


            PersonContainer ps = new PersonContainer();
            Console.ForegroundColor = ConsoleColor.Magenta;
            UI.PrintContainer(ps);

            ps.SortByInn();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            UI.PrintContainer(ps);

            ps.SortByName();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            UI.PrintContainer(ps);


            Console.ReadKey();
        }
    }
}
