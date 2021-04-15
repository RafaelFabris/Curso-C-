using System;
using EnumeracaoComposicao.Entities;
using EnumeracaoComposicao.Entities.Enums;
using System.Globalization;

namespace EnumeracaoComposicao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: " );
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;

            Worker worker = new Worker(name , level , baseSalary , new Department(deptName));

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #"+i+" contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour:");
                double valuePerHours = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HoursContract hoursContract = new HoursContract(date , valuePerHours , hours);
                worker.AddContract(hoursContract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string mouthAndYear = Console.ReadLine();
            int mouth = int.Parse(mouthAndYear.Substring(0, 2));
            int year = int.Parse(mouthAndYear.Substring(3));
            Console.WriteLine("Name: "+worker.Name);
            Console.WriteLine("Department: "+worker.Department.Name);
            Console.WriteLine("Income for "+ mouthAndYear + ": " + worker.Income(year , mouth).ToString("F2") , CultureInfo.InvariantCulture);

            /*
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
            */

        }
    }
}
