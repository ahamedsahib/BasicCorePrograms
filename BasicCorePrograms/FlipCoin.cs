using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class FlipCoin
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter The number of times to Flip Coin");
            int num = Convert.ToInt32(Console.ReadLine());
            FindFlipCoinPercentage(num);
        }
        private static void FindFlipCoinPercentage(int num)
        {
            int head = 0, tail = 0;
            double flip, headPercentage, tailPercentage;
            Random rand = new Random();
            for (int i = 0; i < num; i++)
            {
                flip = rand.NextDouble();
                if (flip < 0.5)
                {
                    tail++;
                }
                else
                {
                    head++;
                }
            }
            Console.WriteLine($"Head =  {head}");
            Console.WriteLine($"Tail =  {tail}");

            headPercentage = Math.Round( (double)head / num * 100,2);
            tailPercentage = Math.Round((double)tail / num * 100,2);

            Console.WriteLine($"Head Percentage : {headPercentage} %");
            Console.WriteLine($"Tail Percentage : {tailPercentage} %");


        }
            
            
    } 
    
}
