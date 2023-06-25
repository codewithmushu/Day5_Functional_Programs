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
    }
}
