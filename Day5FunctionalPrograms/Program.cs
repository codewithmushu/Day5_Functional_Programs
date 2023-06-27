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
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        }
    }
}
