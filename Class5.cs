using System;
class TypeConversion
{
    public static void TypeConvertlongfromInt(int value)
    {
        // Example of implicit conversion
        int intValue = value;
        long longValue = intValue; // Implicit conversion from int to long
        System.Console.WriteLine("Implicit conversion:" + longValue);
    }
    public static void TypeConvertIntfromlong(long value) {
        // Example of explicit conversion
        long longvalue = value;
        int intFromLong = (int)longvalue;
        // Explicit conversion from double to int
        System.Console.WriteLine("Explicit conversion: " + intFromLong);
    }
        //long large= 2147483649+ 2147483646;
        //int x = (int)large;
        //Console.WriteLine(x);
        //long longValue2 = 2147483648;// int.MaxValue + 1;
        //int intFromLong2 = (int)longValue2; // Explicit conversion from long to int
        //System.Console.WriteLine("Explicit conversion from long to int: " + intFromLong2);
    }
