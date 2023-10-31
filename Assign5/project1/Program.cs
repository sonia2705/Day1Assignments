using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assign5_s;

namespace Assign5_s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.GetDetails();
            Console.WriteLine("Account details are : \n");
            account.displaydetails();
            Console.WriteLine("Enter amount to withdraw : ");
            double amount = Double.Parse(Console.ReadLine());
            if(account.WithDraw(amount)== true){
                account.Balance = account.Balance - amount;
                Console.WriteLine("updated Account details are : \n");
                account.displaydetails();
            }
            List<Account> accountlist = new List<Account>() {
            new Account()  { Id = 11, AccountType = "Savings", Balance = 10000},
            new Account()  { Id = 12, AccountType = "Savings", Balance = 12000},
            new Account()  { Id = 13, AccountType = "Current", Balance = 8000},
            new Account()  { Id = 14, AccountType = "Savings", Balance = 11000},
            new Account()  { Id = 15, AccountType = "Savings", Balance = 7000},
            new Account()  { Id = 16, AccountType = "Current", Balance = 9000},
            new Account()  { Id = 17, AccountType = "Current", Balance = 4000},
            new Account()  { Id = 18, AccountType = "Savings", Balance = 17000},
            new Account()  { Id = 19, AccountType = "Savings", Balance = 7500},
            new Account()  { Id = 20, AccountType = "Current", Balance = 9700},
            };
            List<int> amountlist = new List<int>() { 5000, 9000, 9000, 1000, 2000, 10000, 1000, 2000, 8000, 6000 };
            for(int i = 0; i < amountlist.Count; i++)
            {
                if (accountlist[i].WithDraw(amountlist[i]) == true)
                {
                    accountlist[i].Balance = accountlist[i].Balance - amountlist[i];
                    Console.WriteLine("updated Account details are : \n");
                    accountlist[i].displaydetails();
                }

            }
           
        }
    }
}
