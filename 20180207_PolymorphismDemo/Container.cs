using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180207_PolymorphismDemo
{
    class Container
    {
        public Container(int size)
        {
            _items = new A[size];
        }

        public void Add(A obj)
        {
            _items[_lastIndex++] = obj;
        }

        public void f4ForAll()
        {
            //for (int i = 0; i < _lastIndex; i++)
            //{
            //    _items[i].f4();
            //}

            foreach (A item in _items)
            {
                if (item != null)
                {
                    item.f4();
                }
            }
        }

        private int _lastIndex = 0;
        private A[] _items;
    }
}
