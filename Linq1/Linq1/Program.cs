﻿using System;
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
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] filds =  sr.ReadLine().Split(';');
                    string name = filds[0];
                    double price = double.Parse(filds[1],CultureInfo.InvariantCulture );
                    list.Add(new Product(name, price));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price: " + avg.ToString("F2" , CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p=>  p.Name).Select(p=> p.Name);

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

        }  
    }
}
