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
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                   FunctionalPrograms.FlipCoin();
                    break;
                case 2:
                    FunctionalPrograms.LeapYear();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        }
    }
}
