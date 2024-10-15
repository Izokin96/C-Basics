using System;  

public class  A3 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Type a number");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type another number");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int result = Math.Abs(number1 - number2);

        if (number1 > number2)
        {
            Console.WriteLine("Result: " +  result);
        }
        else
        {
            Console.WriteLine("The second number is greater");
        }

    }
}


