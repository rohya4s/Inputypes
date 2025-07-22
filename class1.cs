using System;
class MyInput
{
    public static string input()
    {
       Console.WriteLine("Please enter a string value:");
        return Console.ReadLine();
    }
    public static int Intinput()
    {
        Console.WriteLine("Please enter an integer value:");
        int Integerinput;
       bool isinput= int.TryParse(Console.ReadLine(),out Integerinput);
       if(!isinput)
       {
           Console.WriteLine("Invalid input, please enter a valid integer.");
            return  Intinput();
        }
        return Integerinput;
    }
}