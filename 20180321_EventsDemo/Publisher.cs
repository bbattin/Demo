using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180321_EventsDemo
{
    class NextIterationEventArgs : EventArgs
	{
        public NextIterationEventArgs(int i)
        {
            Iter = i;
        }

		// данные, описывающие событие
        public int Iter { get; private set; }
	}

    delegate void NextIteration(object sender, NextIterationEventArgs args);

    class Publisher
    {
        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                OnNextIteration(i);    // запуск события новой итерации
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("i = {0}", i);
            }
        }

        public event NextIteration Iteration
        {
            add
            {
                _nIter += value;
            }
            remove
            {
                _nIter -= value;
            }
        }


        protected void OnNextIteration(int iter)
        {
            if (_nIter != null)
	        {
		        _nIter(this, new NextIterationEventArgs(iter));
	        }
        }

        NextIteration _nIter;

        //static NextIteration _nIter1;
    }
}
