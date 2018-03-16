using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount saver1 = new SavingsAccount(2000.00);
            SavingsAccount saver2 = new SavingsAccount(3000.00);

            SavingsAccount.ModifyInterestRate(0.04);

            saver1.CalculateMonthlyInterest();
            saver1.GetSavingsBalance();
            saver2.CalculateMonthlyInterest();
            saver2.GetSavingsBalance();

            SavingsAccount.ModifyInterestRate(0.05);

            saver1.CalculateMonthlyInterest();
            saver1.GetSavingsBalance();
            saver2.CalculateMonthlyInterest();
            saver2.GetSavingsBalance();

        }
}
}
