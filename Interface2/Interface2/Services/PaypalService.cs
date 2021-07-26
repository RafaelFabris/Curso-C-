using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private const double FeePayment = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePayment;
        }
    }
}
