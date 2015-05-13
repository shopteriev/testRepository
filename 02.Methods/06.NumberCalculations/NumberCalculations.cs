//Write methods to calculate the minimum, maximum, average, sum and product of a given set of numbers. Overload the methods to work with numbers of type double and decimal.
//Note: Do not use LINQ.

using System;
using System.Linq;

class NumberCalculations
{
    static void Main()
    {
        double[] doubleNums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        decimal[] decimalNums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
        Console.WriteLine(GetMin(doubleNums));
        Console.WriteLine(GetMin(decimalNums));
        Console.WriteLine(GetMax(doubleNums));
        Console.WriteLine(GetMax(decimalNums));
        Console.WriteLine(GetAverage(doubleNums));
        Console.WriteLine(GetAverage(decimalNums));
        Console.WriteLine(GetSum(doubleNums));
        Console.WriteLine(GetSum(decimalNums));
        Console.WriteLine(GetProduct(doubleNums));
        Console.WriteLine(GetProduct(decimalNums));
    }
    static double GetMin(double[] numbers)
    {
        double min = double.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }
    static decimal GetMin(decimal[] numbers)
    {
        decimal min = decimal.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }
    static double GetMax(double[] numbers)
    {
        double max = double.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
    static decimal GetMax(decimal[] numbers)
    {
        decimal max = decimal.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
    static double GetAverage(double[] numbers)
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum / numbers.Length;
    }
    static decimal GetAverage(decimal[] numbers)
    {
        decimal sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum / numbers.Length;
    }
    static double GetSum(double[] numbers)
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static decimal GetSum(decimal[] numbers)
    {
        decimal sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static double GetProduct(double[] numbers)
    {
        double product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }

        return product;
    }
    static decimal GetProduct(decimal[] numers)
    {
        decimal product = 1;
        for (int i = 0; i < numers.Length; i++)
        {
            product *= numers[i];
        }

        return product;
    }
}