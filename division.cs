
using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            // program to divide numbers
            int num1 = 0;
            int num2 = 0;
            int result = 0;

            //collect values from user
            Console.Write("please input your first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("please input the first number: ");
            num2 = int.Parse(Console.ReadLine());

            result = num1/num2;
            Console.WriteLine("The answer is: " + result);
        }
    }
}
