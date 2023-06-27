using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5FunctionalPrograms
{
    public class FunctionalPrograms
    {
        public static void FlipCoin()
        {
            Console.WriteLine("Enter the number of times to flip the coin: ");
            int flips = int.Parse(Console.ReadLine());
            int heads = 0;
            int tails = 0;
            Random random = new Random();

            for (int i = 0; i < flips; i++)
            {
                double result = random.NextDouble();
                if (result < 0.5)
                    tails++;
                else
                    heads++;
            }

            double headsPercentage = (double)heads / flips * 100;
            double tailsPercentage = (double)tails / flips * 100;

            Console.WriteLine("Heads: " + headsPercentage.ToString("0.00") + "%");
            Console.WriteLine("Tails: " + tailsPercentage.ToString("0.00") + "%");
        }

        public static void LeapYear()
        {
            Console.WriteLine("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            if (isLeapYear)
                Console.WriteLine(year + " is a leap year.");
            else
                Console.WriteLine(year + " is not a leap year.");
        }

        public static void PowerOf2()
        {
            Console.WriteLine("Enter the power value (0 <= N < 31): ");
            int power = int.Parse(Console.ReadLine());

            if (power >= 0 && power < 31)
            {
                int result = 1;
                for (int i = 0; i <= power; i++)
                {
                    Console.WriteLine("2^" + i + " = " + result);
                    result *= 2;
                }
            }
            else
            {
                Console.WriteLine("Invalid power value.");
            }
        }

        public static void HarmonicNumber()
        {
            Console.WriteLine("Enter the harmonic value (N != 0): ");
            int n = int.Parse(Console.ReadLine());

            if (n != 0)
            {
                double sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += 1.0 / i;
                }

                Console.WriteLine("The " + n + "th harmonic value is: " + sum);
            }
            else
            {
                Console.WriteLine("Invalid harmonic value.");
            }
        }

        public static void Factors()
        {
            Console.WriteLine("Enter a number to find its prime factors: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime factors of " + number + " are: ");
            for (int i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    Console.WriteLine(i);
                    number /= i;
                }
            }
        }
    }
}
