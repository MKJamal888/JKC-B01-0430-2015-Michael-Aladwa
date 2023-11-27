using System;

class Program
{
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp; /* takes two integers as input by reference
         and swaps their values using a temporary variable */
    }

    static void Main() // demonstrates how the Swap function will swap the values of the two integers
    {
        int num1 = 5;
        int num2 = 10;

        Console.WriteLine("Before swap: num1 = " + num1 + ", num2 = " + num2);

        Swap(ref num1, ref num2); // pass arguments by reference

        Console.WriteLine("After swap: num1 = " + num1 + ", num2 = " + num2);
    }
}
