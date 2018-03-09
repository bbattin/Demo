using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180221_InterfacesDemo
{
    class PersonContainer : IContainer
    {
        public object this[int index]
        {
            get
            {
                return _items[index];    // boxing
            }
            set
            {
                _items[index] = (Person)value;    // unboxing
            }
        }

        public int Count
        {
            get
            {                
                return _items.Length;
            }
        }

        public void SortByInn()
        { 
            Array.Sort(_items);    // IComparable
        }

        public void SortByName()
        {
            Array.Sort(_items, new PersonNameComparer());    // IComparer
        }


        protected Person[] _items = new Person[] 
        { 
            new Person() {Name = "Dima", INN = 123},  
            new Person() {Name = "Kolya", INN = 1},
            new Person() {Name = "Vasya", INN = 2}
        };

    }
}
