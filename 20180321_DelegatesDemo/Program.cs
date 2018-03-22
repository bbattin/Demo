using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180321_DelegatesDemo
{
    delegate int ArithmOps(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            ArithmOps op = null;    // !!! reference type

            DelegDemo1(new ArithmOps(Plus));    // занесение адреса статической ф-ии <Plus> в переменную-делегат <op>
            DelegDemo1(new ArithmOps(Minus));    // занесение адреса ф-ии <Plus> в переменную-делегат <op>

            //DelegDemo2();
            DelegDemo2Ops();
            

            #region Member functions

            DemoOp d = new DemoOp();

            ArithmOps opMember = new ArithmOps(d.MyOp);    // занесение адреса метода <MyOp>, вызываемой относительно экземпляра класса <DemoOp> в переменную-делегат <op>

            int k2 = opMember(1, 2);

            Console.WriteLine("k2 = {0}", k2);
            
            #endregion


            Console.ReadKey();
        }

        private static void DelegDemo2()
        {
            // Combine формирование нового делегата на основе других ("комбинирование")
            ArithmOps op = (ArithmOps)Delegate.Combine(new ArithmOps(Plus), new ArithmOps(Minus));
            op(3, 10);

            op = (ArithmOps)Delegate.Combine(op, new ArithmOps(Minus));
            Console.ForegroundColor = ConsoleColor.Cyan;
            op(3, 10);

            op = (ArithmOps)Delegate.Combine(op, new ArithmOps(Plus));
            Console.ForegroundColor = ConsoleColor.Yellow;
            int result = op(23, 210);

            Delegate[] methods = op.GetInvocationList();

            // исключение последне метода из списка вызовов
            op = (ArithmOps)Delegate.Remove(op, new ArithmOps(Plus));
            Console.ForegroundColor = ConsoleColor.Magenta;
            op(23, 210);

            // исключение всех вызовов метода из списка вызовов
            op = (ArithmOps)Delegate.RemoveAll(op, new ArithmOps(Minus));
            Console.ForegroundColor = ConsoleColor.Green;
            op(31, 20);
        }

        // Упрощенный вариант синтаксиса
        private static void DelegDemo2Ops()
        {
            // Combine формирование нового делегата на основе других ("комбинирование")
            ArithmOps op = Plus;    // в <op> помещаем адрес метода <Plus>
            op += Minus;

            op(3, 10);

            op += Minus;    // op = (ArithmOps)Delegate.Combine(op, new ArithmOps(Minus));
            Console.ForegroundColor = ConsoleColor.Cyan;
            op(3, 10);

            op += Plus;    // op = (ArithmOps)Delegate.Combine(op, new ArithmOps(Plus));
            Console.ForegroundColor = ConsoleColor.Yellow;
            int result = op(23, 210);

            Delegate[] methods = op.GetInvocationList();

            // исключение последне метода из списка вызовов
            op -= Plus;    // op = (ArithmOps)Delegate.Remove(op, new ArithmOps(Plus));
            Console.ForegroundColor = ConsoleColor.Magenta;
            op(23, 210);

            // исключение всех вызовов метода из списка вызовов
            op = (ArithmOps)Delegate.RemoveAll(op, new ArithmOps(Minus));
            Console.ForegroundColor = ConsoleColor.Green;
            if (op != null)
            {
                op(31, 20);    
            }
            
        }

        private static void DelegDemo1(ArithmOps op)
        {
            // несоответствие сигнатуры
            // op = new ArithmOps(Plus3);    // занесение адреса ф-ии <Plus> в переменную-делегат <op>

            int k = op(2, 7);

            Console.WriteLine("k = {0}", k);
        }

        static int Plus(int a, int b)
        {
            Console.WriteLine("Plus({0}, {1})", a, b);
            return a + b;
        }

        static int Plus3(int a, int b, int c)
        {
            return a + b + c;
        }

        static int Minus(int a, int b)
        {
            Console.WriteLine("Minus({0}, {1})", a, b);
            return a - b;
        }

    }
}
