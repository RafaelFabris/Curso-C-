using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance5.Entities
{
    abstract class TaxPlayer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        protected TaxPlayer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();
            


            
    }
}
