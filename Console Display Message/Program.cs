using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!"); 
            Console.WriteLine("What's your name?"); 
            string name = Console.ReadLine();
            Console.WriteLine("What's your zip code?"); 
            string zipCode = Console.ReadLine();
            Console.WriteLine("What's your gross monthly pay?");
            Console.Write("$");
            string grossPay = Console.ReadLine();
            double taxes = System.Math.Round(double.Parse(grossPay) * 0.07, 2); // Converts grossPay to double, computes user's monthly taxes by taking 7%, and rounds it to two digits
            Console.WriteLine($"Name: {name}"); 
            Console.WriteLine($"Zip code: {zipCode}"); 
            Console.WriteLine($"Gross monthly pay: ${grossPay}");
            Console.WriteLine($"Monthly taxes: ${taxes}"); 
            Console.WriteLine("Press the enter key to close the program.");
        }
    }
}
