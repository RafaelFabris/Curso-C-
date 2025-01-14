﻿using System;
using interfaces1.Entities;
using interfaces1.Services;

namespace interfaces1.Services
{
    class RentalServic
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxkService _taxkService;

        public RentalServic(double pricePerHour, double pricePerDay , ITaxkService taxkService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxkService = taxkService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if(duration.TotalHours <= 12.00)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);

            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxkService.Tax(basicPayment);

            carRental.invoice = new Invoice(basicPayment , tax);
        }
    }
}
