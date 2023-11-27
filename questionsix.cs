using System;

class Program
{
    static int GetPrefixLength(string str, string prefix)
    {
        if (str.StartsWith(prefix))
        {
            return prefix.Length;
        }
        else
        {
            return -1;
        }
    }

    static void Main()
    {
        string myString = "Application programming";
        string prefix = "Application";
        int prefixLength = GetPrefixLength(myString, prefix);

        if (prefixLength != -1)
        {
            Console.WriteLine("The length of the prefix '" + prefix + "' in the string '" + myString + "' is " + prefixLength + ".");
        }
        else
        {
            Console.WriteLine("The string '" + myString + "' does not start with the prefix '" + prefix + "'.");
        }
    }
}
