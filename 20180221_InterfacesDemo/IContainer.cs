using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180221_InterfacesDemo
{
    // 1. Объявление "контракта"
    interface IContainer
    {
        object this[int index] { get; set; }
        int Count { get; }
    }
}
