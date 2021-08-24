using System;

namespace subtration
{
    class Program
    {
        static void Main(string[] args)
        {
           //Program to subtract integer values
           int value1 = 0;
           int value2 = 0;
           int result = 0;

           //collect the values to be subtracted
           Console.Write("input first value: ");
           value1 = int.Parse(Console.ReadLine());

           Console.Write("input the second value: ");
           value2 = int.Parse(Console.ReadLine());

           //the result of the subtration
           result = value1 - value2;
           Console.WriteLine("The Answer is: " + result);
           
        }
    }
}
