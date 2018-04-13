using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180411_GenericDemo
{
    interface IContainer<T> : IEnumerable<T>
    {
        int Count { get; }
        T this[int index] { get; set; }
    }
}
