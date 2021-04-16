using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance5.Entities
{
    class Individual : TaxPlayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name , double annualIncome, double healthExpenditures) : base(name , annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double sum = 0.0;
            if(AnnualIncome <= 20000.00)
            {
                if(HealthExpenditures > 0)
                {
                    sum = AnnualIncome * 0.15 - HealthExpenditures * 0.5;
                }
                else
                {
                    sum = AnnualIncome * 0.15;
                }
            }
            else
            {
                if(HealthExpenditures > 0)
                {
                    sum = AnnualIncome * 0.25 - HealthExpenditures * 0.5;
                }
                else
                {
                    sum = AnnualIncome * 0.25;
                }
            }
            return sum;
            
        }
    }
}
