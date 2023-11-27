using System;

class Program
{
    static void PrintReverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine(new string(charArray));
    }

    static void Main()
    {
        string myString = "Application Programming";
        PrintReverse(myString);
    }
}
