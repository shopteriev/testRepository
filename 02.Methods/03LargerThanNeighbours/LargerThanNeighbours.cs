//Write a method that checks if the element at given position in a given array of integers is larger than its two neighbours (when such exist).

using System;
using System.Linq; // to use Select()


class LargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Please, enter some integers, separated by a single space: ");
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
        }
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











//long way ...bool structure is loner but more undersandable

//using System;


//class LargerThanNeighbours
//{
//    static void Main()
//    {
//        int[] numbers = { 7, 3, 4, 5, 5, 6, 5 };

//        for (int i = 0; i < numbers.Length; i++)
//        {
//            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
//        }
//    }
//    static bool IsLargerThanNeighbours(int[] numbers, int i)//
//    {
//        bool isLarger = false;
//        if (i == 0)
//        {
//            if (numbers[i] > numbers[i + 1])
//            {
//                isLarger = true;
//            }
//        }
//        else if (i > 0 && i < numbers.Length - 1)//
//        {
//            if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
//            {
//                isLarger = true;
//            }
//        }
//        else //i = numbers.Lenght -1
//        {

//            if (numbers[i] > numbers[i - 1])
//            {
//                isLarger = true;
//            }
//        }
//        return isLarger;
//    }
//}