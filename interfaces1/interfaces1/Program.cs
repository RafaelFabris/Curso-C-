﻿using System;
using System.Globalization;
using interfaces1.Entities;
using interfaces1.Services;

namespace interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.WriteLine("Car model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm" , CultureInfo.InvariantCulture);
            Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Enter price per hour: ");
            double priceHours = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            Console.WriteLine("Enter price per day: ");
            double priceDays = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

            
            CarRental carRental = new CarRental(start , finish , new Vehicle(model));
            RentalServic rentalServic = new RentalServic(priceHours, priceDays,  new BrasilTaxService());
            rentalServic.ProcessInvoice(carRental);
            Console.WriteLine(carRental.invoice.ToString());

        }
    }
}
