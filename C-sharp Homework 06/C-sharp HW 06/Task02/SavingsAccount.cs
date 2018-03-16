using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class SavingsAccount
    {
        public int Id { get; private set; }
        private static int _count = 1;
        public static List<SavingsAccount> savingsAccounts = new List<SavingsAccount>();

        private static double _annualInterestRate;
        private double _savingsBalance;
        private double monthlyInterestRate;

        public SavingsAccount()
        {
            _savingsBalance = 0;
            _annualInterestRate = 0;
            this.Id = _count++;
            savingsAccounts.Add(this);
        }

        public SavingsAccount(double savingsBalance)
        {
            this._savingsBalance = savingsBalance;
            this.Id = _count++;
            savingsAccounts.Add(this);
        }

        public double GetSavingsBalance()
        {
            double savingsBalanceWithRate = _savingsBalance + monthlyInterestRate;
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine($"Initial savings balance for account no. {this.Id}: {_savingsBalance}\nWith monthly interest rate: {savingsBalanceWithRate}");
            return savingsBalanceWithRate;
        }

        public static double GetAnnualInterestRate()
        {
            return _annualInterestRate;
        }

        public double CalculateMonthlyInterest()
        {
            monthlyInterestRate = (_savingsBalance * _annualInterestRate) / 12;
            double newSavingsBalance = _savingsBalance + monthlyInterestRate;
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine($"Monthly interest rate for account no. {this.Id} at rate {_annualInterestRate}: {monthlyInterestRate}\nNew savings balance (with monthly interest rate): {newSavingsBalance}");
            return monthlyInterestRate;
        }

        public static double ModifyInterestRate(double newAnnualInterestRate)
        {
            if (newAnnualInterestRate >= 0 && newAnnualInterestRate <= 1)
            {
                _annualInterestRate = newAnnualInterestRate;
            }
            else
            {
                Console.WriteLine("The annual interest rate should be set to a value between 0 and 1");
            }
            _annualInterestRate = newAnnualInterestRate;
            return _annualInterestRate;
        }
    }
}
