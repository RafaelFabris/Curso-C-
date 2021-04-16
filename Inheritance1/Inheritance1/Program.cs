using System;
using Inheritance1.Entities;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001 , "Alex" , 500.0);
            BusinessAccount bacc = new BusinessAccount(1002 , "Maria", 0.0 , 500.0);

            // Upcasting 
            Account acc1 = bacc;

            Account acc2 = new BusinessAccount(1003 , "Bob", 0.0 , 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 500.0, 0.01);

            //Downcasting

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100);

            // BusinessAccount acc5 = (BusinessAccount)acc3; // Erro na execução

            /*if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan");
            }
            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }*/

            //Override
            acc.Withdraw(10);
            acc3.Withdraw(10);

            Console.WriteLine("Override");
            Console.WriteLine(acc.Balance);
            Console.WriteLine(acc3.Balance);



        }
    }
}
