using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180221_InterfacesDemo
{
    class UI
    {
        /// <summary>
        /// Печать содержимого контейнера 2. Ипользование контракта (use)
        /// </summary>
        /// <param name="c">интерфейсная ссылка</param>
        public static void PrintContainer(IContainer c)
        {
            if (c == null)
            {
                Console.WriteLine("Контейнер пуст!");
                return;
            }
            for (int i = 0; i < c.Count; i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }
}
