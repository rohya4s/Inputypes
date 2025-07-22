using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inputypes
{
    internal class Operations
    {
        public static void Add(int x,int y)
        {
            Console.WriteLine("Addition of two number is: "+(x + y));
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine("Addition of two number is: " + (x - y));
        }
        public static void Mul(int x, int y)
        {
            Console.WriteLine("Addition of two number is: " + (x * y));
        }
        public static void Div(int x, int y)
        {
            Console.WriteLine("Addition of two number is: " + (x / y));
        }
    }
}
