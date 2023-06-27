using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5FunctionalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Flip Coin and print percentage of Heads and Tails");
            Console.WriteLine("2. Leap Year");
            Console.WriteLine("3. Power of 2");
            Console.WriteLine("4. Harmonic Number");
            Console.WriteLine("5. Factors");
            Console.WriteLine("6. Compute Quotient and Remainder");
            Console.WriteLine("7. Swap Two Numbers");
            Console.WriteLine("8. Check Whether a Number is Even or Odd");
            Console.WriteLine("9. Check Whether an Alphabet is Vowel or Consonant");
            Console.WriteLine("10. Find the Largest Among Three Numbers");
            Console.WriteLine("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                   FunctionalPrograms.FlipCoin();
                    break;
                case 2:
                    FunctionalPrograms.LeapYear();
                    break;
                case 3:
                    FunctionalPrograms.PowerOf2();
                    break;
                case 4:
                    FunctionalPrograms.HarmonicNumber();
                    break;
                case 5:
                    FunctionalPrograms.Factors();
                    break;
                case 6:
                    FunctionalPrograms.ComputeQuotientAndRemainder();
                    break;
                case 7:
                    FunctionalPrograms.SwapTwoNumbers();
                    break;
                case 8:
                    FunctionalPrograms.CheckEvenOrOdd();
                    break;
                case 9:
                    FunctionalPrograms.CheckVowelOrConsonant();
                    break;
                case 10:
                    FunctionalPrograms.FindLargestAmongThreeNumbers();
                    break;  
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        }
    }
}
