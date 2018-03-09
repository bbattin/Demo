using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180307_OpOverloadingDemo
{
    class MyInt
    {
        public MyInt(int n)
        {
            _n = n;
        }

        #region Арифметические операции

        public static MyInt Plus(MyInt a, MyInt b)
        {
            return new MyInt(a._n + b._n);
        }

        public static MyInt operator +(MyInt a, MyInt b)
        {
            return Plus(a, b);
        }

        public static MyInt operator +(MyInt a, int b)
        {
            return new MyInt(a._n + b);
        }

        public static MyInt operator ++(MyInt arg)
        {
            return new MyInt(arg._n + 2);
        }

        public static MyInt operator --(MyInt arg)
        {
            // пример неправильной перегрузки !!!
            // 1. будет работать правильно только для префиксной формы
            // 2. нет объекта, сохраняющего предыдущее состояние
            arg._n-=2;
            return arg;
        }

        #endregion

        #region Перегрузка операций сравнения

        public static bool operator >=(MyInt a, MyInt b)
        {
            return a._n >= b._n;
        }

        public static bool operator <=(MyInt a, MyInt b)
        {
            return a._n <= b._n;
        }

        #endregion


        public override string ToString()
        {
            return string.Format("{0}", _n);
        }

        public int N
        {
            get 
            {
                return _n;
            }
            set
            {
                _n = value;
            }
        }

        private int _n;
    }
}
