using System;
using System.Collections/*.Generic*/;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180221_StdIntrfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] src = new int[] { 12, 1, -2, 3, 978 };

            foreach (int item in src)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            // Работа foreach через while
            IEnumerator it = src.GetEnumerator();
            while (it.MoveNext())
            {
                Console.Write("{0}\t", it.Current);
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;

            DoubleContainer ctr = new DoubleContainer();

            foreach (double item in ctr)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
