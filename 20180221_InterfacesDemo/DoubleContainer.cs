using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180221_InterfacesDemo
{
    class DoubleContainer : IContainer
    {
        public object this[int index]
        {
            get
            {
                return _items[index];    // boxing
            }
            set
            {
                _items[index] = (int)value;    // unboxing
            }
        }

        public int Count
        {
            get
            {
                Console.WriteLine("DoubleContainer.Count");
                return _items.Length;
            }
        }


        protected double[] _items = new double[] { 12.0, -2.8, 31.2, 4.1 };

    }
}
