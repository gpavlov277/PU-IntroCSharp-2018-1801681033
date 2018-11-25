using System;

namespace Circle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            const double pi = Math.PI;                
            double circleRadius = rand.Next(33, 188);   
            double circleArea = pi * circleRadius*circleRadius;

            
            Console.WriteLine("The circle's random height is: " + circleRadius);
          
            Console.WriteLine("The circle's area is: {0:F2}", circleArea);
        }
    }
}
