using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180411_GenericDemo
{
    // T - передаваемый в качестве параметра тип данных
    //     !!! нельзя создать экземпляр класса, не указав параметризованный тип данных
    class Container<T> : IContainer<T> 
    {
        public Container(int size)
        {
            _items = new T[size];
        }

        public T this[int index]
        {
            get
            {
                return _items[index];
            }
            set
            {
                _items[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public void Add(T item)
        {
            _items[_count++] = item;    // !!! отсутствие упаковки !!!
        }

        private int _count = 0;
        private T[] _items;    // элементы контейнера

        //public IEnumerator GetEnumerator()
        //{
        //    //for (int i = 0; i < _count; i++)
        //    //{
        //    //    yield return _items[i];
        //    //}

        //    for (int i = 0; i < _items.Length; i++)
        //    {
        //        if (_items[i] == null)
        //        {
        //            yield break;
        //        }
        //        yield return _items[i];
        //    }
        //}

        //public IEnumerable Reverse()
        //{
        //    for (int i = _count - 1; i >= 0; i--)
        //    {
        //        yield return _items[i];
        //    }
        //}

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _items[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
