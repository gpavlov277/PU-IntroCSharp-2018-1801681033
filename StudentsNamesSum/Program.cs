using System;
using System.IO;

namespace StudentsNamesSum
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.OutputEncoding = System.Text.Encoding.UTF8;


            

                string[] lines = File.ReadAllLines(@"D:\PU 2018-2019\PU-IntroCSharp-2018-1801681033\PUIntroHomeworks\files\students.txt");

                System.Console.WriteLine("Contents of students.txt = ");
                foreach (string line in lines)
                {
                    string[] currentElements = line.Split(' ');


                    string firstName = currentElements[1];
                   string secondName = currentElements[2];
                    string lastName = currentElements[3];
                    string fullName = $"{firstName} {secondName} {lastName}";
                    int sum = 0;




                for (int i = 0; i < firstName.Length; i++)
                {

                    sum = sum + (int)firstName[i];

                }
                for (int i = 0; i < secondName.Length; i++)
                {

                    sum = sum + (int)secondName[i];

                }
                for (int i = 0; i < lastName.Length; i++)
                {

                    sum = sum + (int)lastName[i];

                }
                if (sum > 15000)
                {

                    Console.WriteLine($":) {fullName}->{sum}");
                }
            }
            

        }
        }
    }


   