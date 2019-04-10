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
            int TOTAL_DEVS = 3;

            List<SoftwareDevelopers> devs = new List<SoftwareDevelopers>();
            for (int i = 1; i <= TOTAL_DEVS; i++)
            {
                SoftwareDevelopers dev = new SoftwareDevelopers();
                Console.WriteLine($"Name for dev #{i}:");
                dev.SetName(Console.ReadLine());
                Console.WriteLine($"Zip code for dev #{i}:");
                dev.SetZipCode(Console.ReadLine());
                Console.WriteLine($"Gross monthly pay for dev #{i}:");
                Console.Write("$");
                dev.SetPay(decimal.Parse(Console.ReadLine()));
                devs.Add(dev);
                Console.WriteLine();
                
            }
            foreach (SoftwareDevelopers dev in devs)
            {
                dev.PrintData();
            }
            
            Console.WriteLine("Press the enter key to close the program.");
            Console.ReadLine();
        }
    }

    class SoftwareDevelopers
    {
        private string name;
        private string zipCode;
        private decimal grossPay;
        private decimal taxes;
        private static decimal taxRate = 0.07M;

        public SoftwareDevelopers() {}

        public SoftwareDevelopers(string name, string zipCode, decimal grossPay)
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
            return string.Format("{0:C}", grossPay);
        }

        public string GetTaxes()
        {
            return string.Format("{0:C}", taxes);
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetZipCode(string zipCode)
        {
            this.zipCode = zipCode;
        }

        public void SetPay(decimal grossPay)
        {
            this.grossPay = grossPay;
            taxes = Decimal.Multiply(grossPay, taxRate);
        }

        public void PrintData()
        {
            Console.WriteLine($"Name: {GetName()}");
            Console.WriteLine($"Zip code: {GetZipCode()}");
            Console.WriteLine($"Gross monthly pay: {GetPay()}");
            Console.WriteLine($"Monthly taxes: {GetTaxes()}\n");
        }
    }
}
