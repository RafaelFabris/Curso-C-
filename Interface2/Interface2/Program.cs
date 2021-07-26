using System;
using System.Globalization;
using Interface2.Entities;
using Interface2.Services;

namespace Interface2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.WriteLine("Number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Date (dd/MM/yyyy):");
            DateTime startDate = DateTime.ParseExact(Console.ReadLine() , "dd/MM/yyyy" , CultureInfo.InvariantCulture);
            Console.WriteLine("Contract value:");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter number of installments:");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number,startDate,value);
            ContractService contractService = new ContractService(new PaypalService());

            contractService.ProcessContract(contract , installments);

            Console.WriteLine("Installments: ");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
            
        }
    }
}
