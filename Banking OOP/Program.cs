using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_OOP
{
     class Program
    {
        static void Main(string[] args)
        {
            var giftCard = new GiftCardAccount("gift card", 100, 50);
            giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
            giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
            giftCard.PerformMonthEndTransactions();
            // can make additional deposits:
            giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
            Console.WriteLine(giftCard.GetAccountHistory());

            var savings = new InterestEarningAccount("savings account", 10000);
            savings.MakeDeposit(750, DateTime.Now, "save some money");
            savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
            savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
            savings.PerformMonthEndTransactions();
            Console.WriteLine(savings.GetAccountHistory());


            var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
            // How much is too much to borrow?
            lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
            lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            lineOfCredit.PerformMonthEndTransactions();
            Console.WriteLine(lineOfCredit.GetAccountHistory());

            /*var account = new Bankovní_účet("Týpek", 550);
            Console.WriteLine($"Účet {account.Cislouctu} byl vytvořen pro {account.Vlastnik} s počáteční částkou {account.Castka}");

            //Tady to bych chtěla nějak udělat do příkazového řádku + udělat, aby to vypsalo i částku a poznámky atd.
            account.Výběr(500, DateTime.Now, "Dlužil jsem za pivo");
            Console.WriteLine("Date" + "    Ammount " + "   Note");
            Console.WriteLine(DateTime.Now + " Aktuální částka na Vašem účtě: " + account.Castka);
            account.Vklad(100, DateTime.Now, "Vyhrál jsem sázku");
            Console.WriteLine(DateTime.Now + " Aktuální částka na Vašem účtě: " + account.Castka);*/
        }
    }
}
