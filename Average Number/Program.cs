using System;

namespace Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {


            int evenNumbers = 0;
            double evenNumbersSum = 0;
            bool flag = true;
            do
            {
                Console.WriteLine("Enter a number: ");

                int inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber == 0)
                    flag = false;

                if ((inputNumber >= 1 && inputNumber <= 255) && (inputNumber % 2 == 0))
                {
                    evenNumbersSum += inputNumber;
                    evenNumbers++;
                }
            } while (flag);


            if (evenNumbers == 0)
            {
                Console.WriteLine("There aren't any even numbers between 1 and 255.");
            }
            else
            {
                double evenNumbersAverage = evenNumbersSum / evenNumbers;
                Console.WriteLine("The average of the even numbers between 1 and 255 is: " + evenNumbersAverage);

            }
        }
    }
}
