

using System;

namespace multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // program to multipliply 3 digits
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int result = 0;

            //collect values from user
            Console.Write("please enter the first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("please enter your second number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("please enter the third number: ");
            num3 = int.Parse(Console.ReadLine());

            //multiply the 3 numbers
            result = num1 * num2 * num3;
            Console.WriteLine("The product of the numbers is: " + result);
        }
    }
}
