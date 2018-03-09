using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180221_InterfacesDemo
{
    class Person : IComparable
    {
        public int INN { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Person: {0} - {1}", INN, Name);
        }

        public int CompareTo(object obj)
        {
            Person otherPerson = obj as Person;

            if (otherPerson == null)
            {
                return -1;
            }

            int compareResult = -1;
            if (INN > otherPerson.INN)
            {
                compareResult = 1;
            }
            else
            {
                if (INN == otherPerson.INN)
                {
                    compareResult = 0;
                }

            }

            return compareResult;

            //return INN.CompareTo(otherPerson.INN);
        }
    }

    class PersonNameComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Person first = x as Person;            

            if (first == null)
            {
                return 1;
            }

            Person second = y as Person;

            if (second == null)
            {
                return -1;
            }

            return first.Name.CompareTo(second.Name);
        }
    }
}
