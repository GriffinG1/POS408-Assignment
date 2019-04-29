using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reads data.txt into program
            string[] data = File.ReadAllLines(@"data.txt");

            // Sets total devs for the program to use.
            int TOTAL_DEVS = data.Length;

            Console.WriteLine("Welcome!\n");
            
            List<SoftwareDeveloper> devs = new List<SoftwareDeveloper>();

            for (int i = 0; i < TOTAL_DEVS; i++) // Fills the List devs with a TOTAL_DEVS amount of SoftwareDeveloper objects, while filling them
            {
                string[] devInfo = data[i].Split(',');
                SoftwareDeveloper dev = new SoftwareDeveloper();
                dev.SetName(devInfo[0]);
                dev.SetZipCode(devInfo[1]);
                dev.SetPay(Double.Parse(devInfo[2]));
                dev.SetTaxType(devInfo[3]);
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
            return taxType.ToUpper();
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
