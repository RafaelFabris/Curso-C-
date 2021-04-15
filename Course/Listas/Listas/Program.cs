using System;
using System.Collections.Generic;
using System.Globalization;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for(int i=  1; i<=n; i++)
            {
                Console.WriteLine("Employee #"+i+":");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name , salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase :");
            int searchID = int.Parse(Console.ReadLine());

            Employee emp = employees.Find(x => x.Id == searchID);
            if(emp != null)
            {
                Console.Write("Enter the percentage:");
                int percentage = int.Parse(Console.ReadLine());
                emp.increasedSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(object obj in employees)
            {
                Console.WriteLine(obj);
            }

            /*List<string> list = new List<String>();
            List<string> list2 = new List<String> { "Maria", "Alex" };

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine(s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Position First A:" + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Position Last A:" + pos2);


            Console.WriteLine("----------------------------");
            List<string> result = list.FindAll(x => x.Length == 5);
            foreach(string obj in result)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------");
            list.RemoveAt(3);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------");
            list.RemoveRange(2 , 2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------");
            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            */
        }
    }
}
