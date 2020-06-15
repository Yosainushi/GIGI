using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_TRPO
{
    class AgeOverSizeException: ArgumentException
    {
        public int Value { get; }
        public AgeOverSizeException(string message, int val)
            : base(message)
        {
            Value = val;
        }
        public void Show()
        {
            Console.WriteLine(Message + $"ему {Value} лет");
        }
    }
}
