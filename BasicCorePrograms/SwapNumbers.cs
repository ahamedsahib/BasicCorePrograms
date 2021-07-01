using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class SwapNumbers
    {
        public static void ReadInput() 
        {
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of num 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            SwapingNumbers(num1, num2);
        }
        private static void SwapingNumbers(int num1, int num2)
        {
            Console.WriteLine("Before Swapping");
            Console.WriteLine($"FirstNumber = {num1} SecondNumber = {num2}");


            num1 = num1 + num2;//swapping without 3rd variable
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("After Swapping");
            Console.WriteLine($"FirstNumber = {num1} SecondNumber = {num2}");
        }
    }
}
