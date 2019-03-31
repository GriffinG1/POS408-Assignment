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
            Console.Write(typeof(string).Assembly.ImageRuntimeVersion);
            Console.WriteLine("Welcome!"); // Greets the user
            Console.WriteLine("What's your name?"); // Asks for user's name
            string name = Console.ReadLine(); // Takes user's name and assigns it to string name
            Console.WriteLine("What's your zip code?"); // Asks for user's zip code
            bool zipNumeric = int.TryParse(Console.ReadLine(), out int zipCode); // Takes user's zip code, attempts to convert it to int, and assigns it to int zipCode if successful
            while (!zipNumeric) // Forces users to input an integer
            {
                Console.WriteLine("Your zip code must be an integer. What's your zip code?");
                zipNumeric = int.TryParse(Console.ReadLine(), out zipCode);
            }
            Console.WriteLine("What's your gross monthly pay?"); // Asks for user's gross monthly pay
            bool payNumeric = int.TryParse(Console.ReadLine(), out int grossPay); // Takes user's gross monthly pay, attempts to convert it to int, and assigns it to int grossPay if successful
            while (!payNumeric) // Forces users to input an integer
            {
                Console.WriteLine("Your pay must be an integer. What's your gross monthly pay?");
                payNumeric = int.TryParse(Console.ReadLine(), out grossPay);
            }
            double taxes = Convert.ToDouble(grossPay) * 0.07; // Computes user's monthly taxes by taking 7% of user's gross monthly pay
            Console.WriteLine($"Name: {name}"); // Outputs user's name
            Console.WriteLine($"Zip code: {zipCode}"); // Outputs user's zip code
            Console.WriteLine($"Gross monthly pay: {grossPay}"); // Outputs user's gross monthly pay
            Console.WriteLine($"Monthly taxes: {taxes}"); // Outputs user's monthly taxes
            Console.WriteLine("Press \"enter\" to close the program."); // Advises the user on how to properly exit the program
            Console.ReadLine(); // Allows input and waits for Enter to be pressed
        }
    }
}
