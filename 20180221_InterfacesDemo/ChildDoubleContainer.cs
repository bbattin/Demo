using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180221_InterfacesDemo
{
    class ChildDoubleContainer : DoubleContainer, IContainer    // своя реализация IContainer
    {
        public object this[int index]
        {
            get
            {
                return _items[index]*2.0;    // boxing
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
                Console.WriteLine("ChildDoubleContainer.Count");
                return _items.Length;
            }
        }
    }
}
