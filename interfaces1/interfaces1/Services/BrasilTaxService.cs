﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces1.Services
{
    class BrasilTaxService : ITaxkService
    {
        public double Tax(double amount)
        {
            if (amount <= 100) return amount * 0.2;

            else return amount * 0.15;



        }
    }
}
