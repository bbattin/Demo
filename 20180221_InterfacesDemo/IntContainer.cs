using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180221_InterfacesDemo
{
    // Реализация интерфейса (implementation)
    struct IntContainer : IContainer
    {
        public IntContainer(int size)
        {
            Random rnd = new Random();

            _items = new int[size];
            for (int i = 0; i < _items.Length; i++)
            {
                _items[i] = rnd.Next(-10, 10);
            }
        }

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
                return _items.Length;
            }
        }

        private int[] _items;
    }
}
