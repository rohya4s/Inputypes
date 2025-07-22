using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inputypes
{
    internal class class2

    {
        public static void ValueType() { 
        int x = 10;
        int y = x;
        y=20;
            Console.WriteLine("Value Type Example");
            Console.WriteLine(x); // Output: 10
        }
        public static void ReferenceType()
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = arr1;
            arr2[0] = 10;
            Console.WriteLine("Reference Type Example"+arr1);// Output: 10, 2, 3
        }
    }
}
