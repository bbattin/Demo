using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180207_PolymorphismDemo
{
    // abstract - определяет "абстрактность класса", т.е. его экземпляры нельзя создать
    abstract class A
    {
        public void f1()
        {
            Console.WriteLine("A.f1()");
        }

        // f3() - виртуальный метод, которые может переопределяться в классах-потомках
        public virtual void f3()
        {
            Console.WriteLine("A.f3()");
        }

        // объявление чисто виртуального метода
        public abstract void f4();
    }
}
