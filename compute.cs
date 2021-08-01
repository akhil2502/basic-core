
using System;
public class vowles
{
    public static void Main()
    {
        int a, b;
        int dividend, divisor;
        Console.WriteLine("enter the dividend value");
        dividend = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the divisorvalue");
        divisor = Convert.ToInt32(Console.ReadLine());
        int quotient = dividend / divisor;
        int remainder = dividend % divisor;
        Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
        Console.WriteLine("Quotient = " + quotient);
        Console.WriteLine("Remainder = " + remainder);
        Console.ReadLine();
    }
    

        
    }
