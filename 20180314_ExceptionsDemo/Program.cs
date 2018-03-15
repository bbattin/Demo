using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180314_ExceptionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 0;

            int c;

            if (Div1(a, b, out c))
            {
                Console.WriteLine("{0} / {1} = {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("{0} / {1} - Нельзя делить на 0!!! (анализ кода возврата)", a, b);
            }


            try
            {
                //b = TestException(a, b);
                b = TestSelfException(a, b);
                
            }
            catch (SecondArgIsZerroException ex)
            {
                //Console.WriteLine("Message: {0}", ex.Message);
                Console.WriteLine("{0} Exception: {1}", ex.CreatedDate, ex);

                // Обработка дополнительных параметров исключения (словарь параметров)

                foreach (var key in ex.Data.Keys)
                {
                    var val = ex.Data[key];
                    Console.WriteLine("ex.Data[{0}] = {1}", key, val);
                }

                int aEx = (int)ex.Data["a"];

                //throw;
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Message: {0}", ex.Message);
                Console.WriteLine("Exception: {0}", ex);
                //throw;
            }
            


            #region MyRegion
            
            #endregion

            Console.ReadKey();
        }

        private static int TestException(int a, int b)
        {
            try
            {
                Console.Write("Enter b: ? ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} / {1} = {2}", a, b, Div2(a, b));                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("{0} / {1} - Нельзя делить на 0!!! (обработка исключения)", a, b);
            }            
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("---=== !!!!");
            }

            // Не будет выполняться при появлении FormatException
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("OK: end of TestException()");

            return b;
        }

        private static int TestSelfException(int a, int b)
        {
            //if (b == 0)
            //{
            //    throw new SecondArgIsZerroException("2-й аргумент д.б. не равен 0!!!");
            //}

            try
            {
                Console.Write("Enter b: ? ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} / {1} = {2}", a, b, Div2(a, b));
            }
            catch (DivideByZeroException ex)
            {
                SecondArgIsZerroException myEx = new SecondArgIsZerroException(string.Format("{0} / {1} - Нельзя делить на 0!!! (обработка исключения)", a, b), ex);

                myEx.Data.Add("a", a);
                myEx.Data.Add("b", b);

                throw myEx;          
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("---=== !!!!");
            }

            // Не будет выполняться при появлении FormatException
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("OK: end of TestException()");

            return b;
        }

        private static bool Div1(int a, int b, out int result)
        {
            bool fOk = (b != 0);

            if (fOk)
            {
                result = a / b;    
            }
            else
            {
                result = 0;
            }

            return fOk;
        }

        private static int Div2(int a, int b)
        {
            return a / b;
        }
    }
}
