using System;

namespace Task_4_Using_data_types_and_parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            //A: Ask the user for the first number.
            Console.WriteLine("Please enter the first number.");

            //B: Load user entered number.
            string fstnr = Console.ReadLine();
            int nr1 = int.Parse(fstnr);

            //C: Ask the user to enter a second number.
            Console.WriteLine("Please enter second number.");

            //D: Load user entered number.
            string secnr = Console.ReadLine();
            int nr2 = int.Parse(secnr);

            //E: Display the sum of the given numbers.
            int add2nr = nr1 + nr2;
            Console.WriteLine("The sum of both numbers is: " + add2nr);
        }
    }
}
