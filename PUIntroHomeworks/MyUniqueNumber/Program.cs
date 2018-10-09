using System;

namespace MyUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            int ageAfter10 = age + 10;
            Console.WriteLine("Enter last 4 digits of your faculty number here: ");
            int facultyNumber = int.Parse(Console.ReadLine());
            double result = ((age + 10) * facultyNumber) / pi;
            Console.WriteLine("After 10 yeras you will be " + ageAfter10 + " yeras old. And your unique number is " +result);


        }
    }
}
