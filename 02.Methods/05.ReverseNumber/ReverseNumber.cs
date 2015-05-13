//Write a method that reverses the digits of a given floating-point number.

using System;


class ReverseNumber
{
    static void Main()
    {
        double inputNumber = double.Parse(Console.ReadLine());

        double reversed = GetReversedNumber(inputNumber);
        Console.WriteLine(reversed);

    }

    private static double GetReversedNumber(double input)
    {
        string numberAsString = input.ToString();

        char[] characters = numberAsString.ToCharArray();
        Array.Reverse(characters);

        string reversedString = string.Join("", characters); //new string(characters);
        double result = double.Parse(reversedString);
        return result;
    }
}

