using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Good Day!");


            //string firstName = "Joe";
            //string lastName = "Edoho";
            //Console.WriteLine(firstName + " " + lastName);

            //Console.WriteLine("1");
            //Console.WriteLine("101");
            //Console.WriteLine("1001");

            //DateTime current = DateTime.Now;
            //Console.WriteLine(current);

            //int nuumber = 12345;
            //double squareRoot = Math.Sqrt(nuumber);
            //Console.WriteLine(squareRoot);

            Console.Write("Enter your age: ");
            string? ageStr = Console.ReadLine();
            int age = 0;
            if (ageStr == null)
            {
                age = 0;
            }
            else
            {
                age = int.Parse(ageStr);
            }
            int ageYears = age + 10;
            Console.WriteLine("In 10 years time, you will be " + ageYears + " years old.");
        }
    }
}
