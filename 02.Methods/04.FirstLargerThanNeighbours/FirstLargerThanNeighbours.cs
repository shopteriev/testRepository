//04.Write a method that returns the index of the first element in array that is larger than its neighbours, or -1 if there's no such element. Use the method from the previous exercise in order to re.

using System;
using System.Linq; //to use SElect()


class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Please, enter some integers, separated by a single space: ");
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
        //int[] numbers = { 1, 2, 3, 4, 5, 6, 6 };
        //int[] numbers = { 1, 1,1};

        Console.WriteLine(GetIndexOfFirstElenemtLargerThanNeighbours(numbers));

    }
    static int GetIndexOfFirstElenemtLargerThanNeighbours(int[] numbers)//
    {
        int resultIndex = -1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsLargerThanNeighbours(numbers, i))  //invoces method IsLagerThanNeighbours, returning true or false (it is from project 3)   
            {
                resultIndex = i;
                return resultIndex;
            }
        }
        return resultIndex; //
    }
    static bool IsLargerThanNeighbours(int[] numbers, int i)//
    {
        bool isLarger = false;
        if (i == 0)
        {
            isLarger = numbers[i] > numbers[i + 1];
        }
        else if (i > 0 && i < numbers.Length - 1)//
        {
            isLarger = numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1];
        }
        else //i = numbers.Lenght -1
        {
            isLarger = numbers[i] > numbers[i - 1];
        }
        return isLarger;
    }
}
