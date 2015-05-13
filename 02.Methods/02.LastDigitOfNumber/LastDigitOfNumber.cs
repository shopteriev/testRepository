//02. Write a method that returns the last digit of a given integer as an English word. Test the method with different input values. Ensure you name the method properly


using System;

class LastDigitOfNumber
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(PrintDigitAsWord(inputNumber));
    }


    static string PrintDigitAsWord(int num)
    {
        int lastDigit = Math.Abs(num % 10); //Math.Abs() in case of negative integer 
        string[] numbers = { "zero", "one", "two", "three", "four", "five",
                              "six", "seven", "eight", "nine"};
        return numbers[lastDigit];
    }
}


// Second version

//using System;


//class LastDigitOfNumber
//{
//    static void Main()
//    {
//        int inputNumber = int.Parse(Console.ReadLine());

//        Console.WriteLine(PrintDigitAsWord(inputNumber));
//    }

//    static string PrintDigitAsWord(int number)
//    {
//        int lastNum = Math.Abs(number % 10); //!!!
//        string digitText = " ";
//        switch (lastNum)
//        {
//            case 0:
//                digitText = "zero";
//                break;
//            case 1:
//                digitText = "one";
//                break;
//            case 2:
//                digitText = "two";
//                break;
//            case 3:
//                digitText = "three";
//                break;
//            case 4:
//                digitText = "four";
//                break;
//            case 5:
//                digitText = "five";
//                break;
//            case 6:
//                digitText = "six";
//                break;
//            case 7:
//                digitText = "seven";
//                break;
//            case 8:
//                digitText = "eight";
//                break;
//            case 9:
//                digitText = "nine";
//                break;
//        }
//        return digitText;
//    }
//}

