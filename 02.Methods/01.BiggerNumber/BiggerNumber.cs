//01.Write a method GetMax() with two parameters that returns the larger of two integers. Write a program that reads 2 integers from the console and prints the largest of them using the method GetMax().

using System;

class BiggerNumber
{
    static void Main()
    {
        int firsNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int maxValue = GetMax(firsNumber, secondNumber);
        Console.WriteLine(maxValue);
    }

    static int GetMax(int firstNum, int secondNum)
    {
        int result = Math.Max(firstNum, secondNum);
        return result;
    }
}






















//static int GetMax(int firstNum, int secondNum)
//{
//    int result;
//    if (firstNum >= secondNum)
//    {
//        result = firstNum;
//    }
//    else//(firstNum<secondNum)
//    {
//        result = secondNum;
//    }
//    return result;