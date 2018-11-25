using System;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
             Random rnd = new Random();
            double number;
            double sqrtNumber;
            double sum = 0;

            for (int i = 0; i < 31; i++)
            {
                number= rnd.NextDouble() * rnd.Next(1, 998001);
                sqrtNumber = Math.Sqrt(number);
                Console.WriteLine($"The number for day {i} is: {Math.Round(number, 4)} (sqrt={Math.Round(sqrtNumber, 4)}).");

                if (sqrtNumber >= 1 && sqrtNumber <= 300)
                {
                    sqrtNumber *= 5.1;
                    Console.WriteLine("Bonus for this number is {0:F4}", sqrtNumber);
                    sum += sqrtNumber;
                }
                else if (sqrtNumber > 300 && sqrtNumber <= 600)
                {
                    sqrtNumber *= 10.098;
                    Console.WriteLine("Bonus for this number is {0:F4}", sqrtNumber);
                    sum += sqrtNumber;
                }
                else if (sqrtNumber > 600 && sqrtNumber <= 999)
                {
                    sqrtNumber *= 100.00001;
                    Console.WriteLine("Bonus for this number is {0:F4}", sqrtNumber);
                    sum += sqrtNumber;
                }
                Console.WriteLine("------------------------------------------");
            }
            Console.WriteLine("The bonus for this month is: " + Math.Round(sum, 4));

            double yearlySum = sum * 12;

            Console.WriteLine("Annual sum = " + Math.Round(yearlySum, 4));

            
            if (yearlySum > 1000000)
            {
                Console.WriteLine("Hooray, piggies, your savings for 1 year are more than 1 000 000!!!");
            }
            else
                Console.WriteLine("Piggies, your savings for 1 year are less than 1 000 000.");









        }
             
        
            
        }
    }

