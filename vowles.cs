







using System;
public class vowles
{
    public static void Main()
    {
        char letter;

        Console.Write("Input a letter: ");
        letter = Convert.ToChar(Console.ReadLine());

        if ((letter == 'a') || (letter == 'e') || (letter == 'i') ||
                (letter == 'o') || (letter == 'u'))
            Console.WriteLine("It's a lowercase vowel.");
        else if ((letter == 'A') || (letter == 'E') || (letter == 'I') ||
                (letter == 'O') || (letter == 'U'))
            Console.WriteLine("It's a highercase vowel.");
        else if ((letter >= '0') && (letter <= '9'))
            Console.WriteLine("It's a digit.");
        else
            Console.Write("It's a constant.");
    }
}