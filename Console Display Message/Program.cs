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
            Console.WriteLine("Welcome!"); // Greets the user
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What's your zip code?");
            int zipCode = int.Parse(Console.ReadLine());
            Console.WriteLine("What's your gross monthly pay?");
            int grossPay = int.Parse(Console.ReadLine());
            double taxes = Convert.ToDouble(grossPay) * 0.07;
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Zip code: {zipCode}");
            Console.WriteLine($"Gross monthly pay: {grossPay}");
            Console.WriteLine($"Monthly taxes: {taxes}");
            Console.WriteLine("Press \"enter\" to close the program."); // Advises the user on how to properly exit the program
            Console.ReadLine(); // Allows input and waits for Enter to be pressed
        }
    }
}
