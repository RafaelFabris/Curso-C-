using System;
using System.Linq;
using Linq1.Entities;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full file path: ");
            //string path = Console.ReadLine();
            string path = "c:\\temp\\in.txt";

            Console.Write("Enter de Salary:");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] filds = sr.ReadLine().Split(';');
                    string name = filds[0];
                    string email = filds[1];
                    double salary = double.Parse(filds[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, email, salary));
                }
            }



            var emails = list.Where(p => p.Salary > value).OrderBy(p => p.Email).Select(p => p.Email);

            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }

            var sum = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.WriteLine("Sum of salary of people whose name starts with 'M' :" + sum.ToString("F2" , CultureInfo.InvariantCulture));

        }
    }
}
