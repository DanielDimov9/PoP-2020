using System;

namespace PoP_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;

            Console.Write("Current date:");

            Console.WriteLine(date.ToShortDateString());

            Console.Write("Current time:");

            Console.WriteLine(date.ToShortTimeString());

            Console.Write("Date after 10 years");
            Console.WriteLine(date.AddYears(10).ToShortDateString());

            Console.Write("Please enter period: ");
            int period = int.Parse(Console.ReadLine());
        }
            
    }
}
