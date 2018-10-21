using System;

namespace Miser_Piggy
{
    class Program
    {
        static void Main(string[] args)
        {
            int SumName1 = 0;
            int SumName2 = 0;
            int SumName3 = 0;

            Console.WriteLine("Enter a name Pig1: ");
            string PigName1 = Console.ReadLine();

            Console.WriteLine("Enter a name Pig2: ");
            string PigName2 = Console.ReadLine();



            Console.WriteLine("Enter a name Pig3: ");
            string PigName3 = Console.ReadLine();




            foreach (char a in PigName1)
            {
                SumName1 += a;

            }

            foreach (char b in PigName2)
            {
                SumName2 += b;

            }

            foreach (char c in PigName3)
            {
                SumName3 += c;

            }
      if(SumName1>SumName2 && SumName1>SumName3)

                Console.WriteLine("The most expensive name is Pig1");
      else if (SumName2 > SumName1 && SumName2 > SumName3)


            { Console.WriteLine("The most expensive name is Pig2"); }


            else Console.WriteLine("The most expensive name is Pig3");
        }
    }
}
