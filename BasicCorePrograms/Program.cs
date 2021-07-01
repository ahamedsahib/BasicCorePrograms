using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Basic Core Programs");
            Console.WriteLine("Choose The Program You Want Run");
            Console.WriteLine("1)Flip Coin\n2)Leap Yaar\n3)PowerOf2\n4)Harmonic Number\n5)Prime Factor\n6)Qutient&Remainder");
            Console.WriteLine("7)SwapNumbers\n8)EvenOdd\n9)VowelConsonant\n10)Exit");
            Console.WriteLine("Choose one");
            int option = Convert.ToInt32( Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin.ReadInput();
                    break;
                case 2:
                    LeapYear.ReadInput();
                    break;
                case 3:
                    PowerOf2.ReadInput();
                    break;
                case 4:
                    HarmonicNumber.ReadInput();
                    break;
                case 5:
                    PrimeFactors.ReadInput();
                    break;
                case 6:
                    QuotientRemainder.ReadInput();
                    break;
                case 7:
                    SwapNumbers.ReadInput();
                    break;
                case 8:
                    EvenOdd.ReadInput();
                    break;
                case 9:
                    Alphabet.ReadInput();
                    break;
                default:
                    Console.WriteLine("Choose Correct Option");
                    break;
            }
            

        }
    }
}
