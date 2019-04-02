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
            while (name == "") // forces users to input a name
            {
                Console.WriteLine("I'm sorry, I didn't get that. What's your name?");
                name = Console.ReadLine();
            }
            Console.WriteLine("What's your zip code?"); 
            bool zipNumeric = int.TryParse(Console.ReadLine(), out int zipCode); // Takes user's zip code, attempts to convert it to int, and assigns it to int zipCode if successful
            while (!zipNumeric || zipCode < 10000 || zipCode > 99999) // Forces users to input an integer
            {
                Console.WriteLine("Your zip code must be a five-digit integer. What's your zip code?");
                zipNumeric = int.TryParse(Console.ReadLine(), out zipCode);
            }
            Console.WriteLine("What's your gross monthly pay?");
            bool payNumeric = int.TryParse(Console.ReadLine(), out int grossPay); // Takes user's gross monthly pay, attempts to convert it to int, and assigns it to int grossPay if successful
            while (!payNumeric) // Forces users to input an integer
            {
                Console.WriteLine("Your pay must be an integer. What's your gross monthly pay?");
                payNumeric = int.TryParse(Console.ReadLine(), out grossPay);
            }
            double taxes = Convert.ToDouble(grossPay) * 0.07; // Computes user's monthly taxes by taking 7% of user's gross monthly pay
            Console.WriteLine($"Name: {name}"); 
            Console.WriteLine($"Zip code: {zipCode}"); 
            Console.WriteLine($"Gross monthly pay: {grossPay}");
            Console.WriteLine($"Monthly taxes: {taxes}"); 
            Console.WriteLine("Press the enter key to close the program."); 
            Console.ReadLine(); // Allows input and waits for Enter to be pressed
        }
    }
}
