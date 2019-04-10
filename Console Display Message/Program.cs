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
            // Sets total devs for the program to use.
            int TOTAL_DEVS = 3;

            Console.WriteLine("Welcome!\n");

            List<SoftwareDeveloper> devs = new List<SoftwareDeveloper>();
            for (int i = 1; i <= TOTAL_DEVS; i++) // Fills the List devs with a TOTAL_DEVS amount of SoftwareDeveloper objects, while taking inputs for them
            {
                SoftwareDeveloper dev = new SoftwareDeveloper();
                Console.WriteLine($"Name for dev #{i}:");
                dev.SetName(Console.ReadLine());
                Console.WriteLine($"Zip code for dev #{i}:");
                dev.SetZipCode(Console.ReadLine());
                Console.WriteLine($"Gross monthly pay for dev #{i}:");
                Console.Write("$");
                decimal grossPay;
                bool hasPay = decimal.TryParse(Console.ReadLine(), out grossPay); // Prevents a crash if user inputs no data
                if (hasPay)
                {
                    dev.SetPay(grossPay);
                }
                devs.Add(dev);
                Console.WriteLine();
                
            }
            foreach (SoftwareDeveloper dev in devs)
            {
                dev.PrintData();
            }
            
            Console.WriteLine("Press the enter key to close the program.");
            Console.ReadLine();
        }
    }

    class SoftwareDeveloper
    {
        private string name;
        private string zipCode;
        private decimal grossPay;
        private decimal taxes;
        private static decimal taxRate = 0.07M;

        public SoftwareDeveloper() { }

        public SoftwareDeveloper(string name, string zipCode, decimal grossPay)
        {
            this.name = name;
            this.zipCode = zipCode;
            this.grossPay = grossPay;
            taxes = Decimal.Multiply(grossPay, taxRate);
        }

        public string GetName()
        {
            return name;
        }

        public string GetZipCode()
        {
            return zipCode;
        }

        public string GetPay()
        {
            return string.Format("{0:C}", grossPay); // returns grossPay as a currency
        }

        public string GetTaxes()
        {
            return string.Format("{0:C}", taxes); // returns taxes as a currency
        }

        public void SetName(string name)
        {
            if (name == "") // Allows clean output if no data is set
            {
                this.name = "N/A";
            }
            else
            {
                this.name = name;
            }
        }

        public void SetZipCode(string zipCode)
        {
            if (zipCode == "") // Allows clean output if no data is set
            {
                this.zipCode = "N/A";
            }
            else
            {
                this.zipCode = zipCode;
            }
        }

        public void SetPay(decimal grossPay)
        {
            this.grossPay = grossPay;
            taxes = Decimal.Multiply(grossPay, taxRate); // Multiplies grossPay by the static decimal taxRate to get the dev's monthly taxes
        }

        public void PrintData() // Outputs all the data in a clean block
        {
            Console.WriteLine($"Name: {GetName()}");
            Console.WriteLine($"Zip code: {GetZipCode()}");
            Console.WriteLine($"Gross monthly pay: {GetPay()}");
            Console.WriteLine($"Monthly taxes: {GetTaxes()}\n");
        }
    }
}
