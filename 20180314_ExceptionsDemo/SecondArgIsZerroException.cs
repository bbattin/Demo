using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180314_ExceptionsDemo
{
    class SecondArgIsZerroException : Exception
    {
        public SecondArgIsZerroException()
        {
            CreatedDate = DateTime.Now;
        }

        public SecondArgIsZerroException(string message)
            : base(message)
        {
            CreatedDate = DateTime.Now;
        }

        public SecondArgIsZerroException(string message, Exception innerException)
            : base(message, innerException)
        {
            CreatedDate = DateTime.Now;
        }

        // описание возникшей ситации
        public DateTime CreatedDate { get; private set; }
    }
}
