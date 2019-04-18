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
            int TOTAL_DEVS = 1;

            Console.WriteLine("Welcome!\n");
            
            Dictionary<int, SoftwareDeveloper> devs = new Dictionary<int, SoftwareDeveloper>();

            for (int i = 1; i <= TOTAL_DEVS; i++) // Fills the Dict devs with a TOTAL_DEVS amount of SoftwareDeveloper objects, while taking inputs for them
            {
                SoftwareDeveloper dev = new SoftwareDeveloper();
                Console.WriteLine($"Name for dev #{i}:");
                string name = Console.ReadLine();
                while (name == "") // Loops until user enters a name
                {
                    Console.WriteLine($"Error, you must enter a name.\nName for dev #{i}:");
                    name = Console.ReadLine();
                }
                dev.SetName(name);
                Console.WriteLine($"Zip code for dev #{i}:");
                string zipCode = Console.ReadLine();
                while (zipCode == "") // Loops until user enters a zip code
                {
                    Console.WriteLine($"Error, you must enter a zip code.\nZip code for dev #{i}:");
                    zipCode = Console.ReadLine();
                }
                dev.SetZipCode(zipCode);
                Console.WriteLine($"Gross monthly pay for dev #{i}:");
                double grossPay;
                bool hasPay = double.TryParse(Console.ReadLine(), out grossPay);
                while (!hasPay) // Loops until user enters valid pay
                {
                    Console.WriteLine($"Error, you must enter a valid number.\nGross monthly pay for dev #{i}:");
                    hasPay = double.TryParse(Console.ReadLine(), out grossPay);
                }
                dev.SetPay(grossPay);
                Console.WriteLine($"W2 or 1099 for dev #{i}:");
                string taxType = Console.ReadLine();
                while (!(taxType.ToLower() == "w2") && !(taxType == "1099")) // Loops until user enters valid employee type
                {
                    Console.WriteLine($"Error, you must enter a valid type.\nW2 or 1099 for dev #{i}:");
                    taxType = Console.ReadLine();
                }
                dev.SetTaxType(taxType);
                devs.Add(i, dev);
                Console.WriteLine();
                
            }
            for (int i = 1; i <= TOTAL_DEVS; i++)
            {
                devs[i].PrintData();
            }
            
            Console.WriteLine("Press the enter key to close the program.");
            Console.ReadLine();
        }
    }

    class SoftwareDeveloper
    {
        private string name;
        private string zipCode;
        private string taxType;
        private double grossPay;
        private double taxes;
        private static double taxRate = 0.07;

        public SoftwareDeveloper() { }

        public SoftwareDeveloper(string name, string zipCode, double grossPay)
        {
            this.name = name;
            this.zipCode = zipCode;
            this.grossPay = grossPay;
            taxes = grossPay * taxRate;
        }

        public string GetName()
        {
            return name;
        }

        public string GetZipCode()
        {
            return zipCode;
        }

        public string GetTaxType()
        {
            return taxType;
        }

        public string GetPay()
        {
            return string.Format("{0:C}", grossPay); // returns grossPay as a currency
        }

        public string GetTaxes()
        {
            return string.Format("{0:C}", taxes); // returns taxes as a currency
        }

        public string GetNetPay()
        {
            double netPay = grossPay - taxes;
            return string.Format("{0:C}", netPay); // returns netPay as a currency
        }
        
        public string GetAnnualPay()
        {
            return string.Format("{0:C}", grossPay * 12); // returns grossPay * 12 as a currency
        }

        public string GetAnnualTaxes()
        {
            return string.Format("{0:C}", taxes * 12); // returns taxes * 12 as a currency
        }

        public string GetAnnualNetPay()
        {
            double netPay = (grossPay * 12) - (taxes * 12);
            return string.Format("{0:C}", netPay); // returns netPay as a currency
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetZipCode(string zipCode)
        {
            this.zipCode = zipCode;
        }

        public void SetPay(double grossPay)
        {
            this.grossPay = grossPay;
            taxes = grossPay * taxRate; // Multiplies grossPay by taxRate to get the dev's monthly taxes
        }

        public void SetTaxType(string taxType)
        {
            this.taxType = taxType;
            if (taxType == "1099")
            {
                taxes = 0;
            }
        }

        public void PrintData() // Outputs all the data in a clean block
        {
            Console.WriteLine($"Name: {GetName()}");
            Console.WriteLine($"Zip code: {GetZipCode()}");
            Console.WriteLine($"Employee type: {GetTaxType()}");
            Console.WriteLine($"Gross monthly pay: {GetPay()}");
            Console.WriteLine($"Monthly taxes: {GetTaxes()}");
            Console.WriteLine($"Monthly net pay: {GetNetPay()}");
            Console.WriteLine($"Gross annual pay: {GetAnnualPay()}");
            Console.WriteLine($"Annual taxes: {GetAnnualTaxes()}");
            Console.WriteLine($"Annual net pay: {GetAnnualNetPay()}\n");
        }
    }
}
