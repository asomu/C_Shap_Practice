using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    class Program
    {
        delegate int Mydelegate(int a, int b);

        class Calculator
        {
            public int Plus(int a, int b)
            {
                return a + b;
            }

            public int Minus(int a, int b)
            {
                return a - b;
            }
        }
        static void Main(string[] args)
        {
            var Calc = new Calculator();
            Mydelegate Callback;
            Callback = new Mydelegate(Calc.Plus);
            Console.WriteLine(Callback(3, 4));

            Callback = new Mydelegate(Calc.Minus);
            Console.WriteLine(Callback(7, 4));
        }
    }
}
