using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180328_LambdaDemo
{
    delegate bool Pred1 (int arg1, int arg2);

    class Program
    {
        static void Main(string[] args)
        {
            double[] arr1 = new double[] { 12.0, -10.1, 0.0000000000000000000001 };
            double[] arr2 = new double[] { -12.0, -2.9, 10.2 };

            Console.WriteLine(Array.Find(arr1, MoreThanZerro));
            Console.WriteLine(Array.Find(arr2, MoreThanZerro));

            Console.WriteLine(Array.Find(arr1, EqualZerro));
            Console.WriteLine(Array.Find(arr2, EqualZerro));

            Predicate<double> p1 = delegate(double arg)
            {
                return arg > 10.0 && arg < 20.0;
            };

            Predicate<double> p2 = delegate(double arg)
            {
                return arg > 0.0;
            };

            // Анонимнае методы
            Console.WriteLine(Array.Find(arr2, 
                delegate(double d) 
                { 
                    return d > 0.0 && d < 10.0; 
                }));

            Console.WriteLine(Array.Find(arr2, p2));

            Console.WriteLine(Array.FindIndex(arr2, p2));

            Console.WriteLine(Array.Exists(arr2, p1));

            // Существование элементов массива > 0
            Console.WriteLine(Array.Exists(arr2, item => item > 0.0));

            // Существование элементов массива в диапазоне [a,b]
            double a = 10.0;
            double b = 20.0;
            Console.WriteLine(Array.Exists(arr2, item => item > a && item < b));

            Array.ForEach(arr2, item => { Console.Write("{0}\t", item); });

            double sum = 0.0;
            Array.ForEach(arr2, item => sum += item);
            Console.WriteLine();
            Console.WriteLine("sum = {0}", sum);

            #region Лямбда-выражения            

            Predicate<double> p1_l1 = (double arg) => { return arg > 10.0 && arg < 20.0; };

            Predicate<double> p1_l2 = (arg) => arg > 10.0 && arg < 20.0;

            Predicate<double> p1_l = arg => arg > 10.0 && arg < 20.0;

            Pred1 pFun = delegate(int arg1, int arg2)
            {
                return (arg1 > arg2);
            };

            Pred1 pFun_l = (arg1, arg2) => arg1 > arg2;

            #endregion

            Console.ReadKey();
        }

        private static bool MoreThanZerro(double arg)
        {
            return arg > 0.0;
        }

        private static bool EqualZerro(double arg)
        {
            return Math.Abs(arg) <= 0.000000000000001;
        }
    }
}
