using System;
using System.Collections/*.Generic*/;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180221_StdIntrfacesDemo
{
    class DoubleContainer : IEnumerable //: IContainer
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


        public IEnumerator GetEnumerator()
        {
            return new DoubleContainerEnumerator(_items);
        }
    }

    class DoubleContainerEnumerator : IEnumerator
	{
        public DoubleContainerEnumerator(double[] scr)
        {
            _src = scr;
        }
       
        public object Current
        {
            get 
            {
                return _src[_currentPos];
            }
        }

        public bool MoveNext()
        {
            ++_currentPos;

            return _currentPos < _src.Length;
        }

        public void Reset()
        {
            _currentPos = -1;
        }

        private int _currentPos = -1;
        private readonly double[] _src;
    } 
}
