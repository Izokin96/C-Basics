using System;
using System.Collections.Generic;
public class Exercise6
{
    static void Main(string[] args)
    {
        Console.WriteLine(remove_char("ThermoIcedTea", 1));
        Console.WriteLine(remove_char("ThermoIcedTea", 9));
        Console.WriteLine(remove_char("ThermoIcedTea", 0));
    }

    public static string remove_char(string str, int n)
    {
        return str.Remove(n, 1);
    }
}
