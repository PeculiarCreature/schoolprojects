using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_OOP
{
    public class BankAccount
    {
       public string Vlastnik { get; set; }

       public virtual void PerformMonthEndTransactions() { }

        public decimal Balance 
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }                               
                
        }

       public string Cislouctu { get; }

       private static int accountNumberSeed = 1234567890;

       private List<Transakce> allTransactions = new List<Transakce>();

        private readonly decimal _minimumBalance;

        public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0) { }

        public BankAccount(string name, decimal initialBalance, decimal minimumBalance)
        {
            Cislouctu = accountNumberSeed.ToString();
            accountNumberSeed++;

            Vlastnik = name;
            _minimumBalance = minimumBalance;
            if (initialBalance > 0)
                MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        
        public void MakeDeposit(decimal mnozstvi, DateTime datum, string note)
        {
            if (mnozstvi <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(mnozstvi), "Váš vklad nesmí být záporné číslo");
            }
            var deposit = new Transakce(mnozstvi, datum, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            Transakce overdraftTransaction = CheckWithdrawalLimit(Balance - amount < _minimumBalance);
            Transakce withdrawal = new Transakce(-amount, date, note); //Prý aby transakce mohla být null, dává se před ní otazník, ale mě Visualstudio hlásí, že
                                                                       //"Funkce typy odkazů s možnou hodnotou null není dostupná v jayzce C# 7.3. Použijte prosím jazyk verze 8.0 nebo vyšší"
                                                                       //Úplně nevím jak to udělat tak jsem to prostě nechala bez otazníku:/
            allTransactions.Add(withdrawal);
            if (overdraftTransaction != null)
                allTransactions.Add(overdraftTransaction);
        }

        protected virtual Transakce CheckWithdrawalLimit(bool isOverdrawn)
        {
            if (isOverdrawn)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            else
            {
                return default;
            }
        }

        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Datum.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }

    }
}
