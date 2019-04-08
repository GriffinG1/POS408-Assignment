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
            double grossPay = double.Parse(Console.ReadLine()); // Takes user's gross monthly pay, attempts to convert it to double, and assigns it to grossPay if successful
            double taxes = grossPay * 0.07; // Computes user's monthly taxes by taking 7% of user's gross monthly pay
            Console.WriteLine($"Name: {name}"); 
            Console.WriteLine($"Zip code: {zipCode}"); 
            Console.WriteLine($"Gross monthly pay: {grossPay}");
            Console.WriteLine($"Monthly taxes: {taxes}"); 
            Console.WriteLine("Press the enter key to close the program."); 
            Console.ReadLine(); // Allows input and waits for Enter to be pressed
        }
    }
}
