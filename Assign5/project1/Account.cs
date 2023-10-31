using System;
namespace Assign5_s
{
    public class Account
    {
        int id;
        public int Id 
        { get { return id; }
            set { id = value; }
        }
        string accountType;
        public string AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }
        double balance;
        public double Balance
        {
            get { return balance;}
            set { balance = value; }    
        }
        public void GetDetails()
        {
            
            Console.WriteLine("Enter account id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter account type");
            accountType = Console.ReadLine();
            Console.WriteLine("Enter account balance");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter account type");
            
        }
        public bool WithDraw(double amount)
        {
            if (amount < balance)
            {
                return true;
            }
            else { return false; }
        }
        public void displaydetails()
        {
            Console.WriteLine($"Account ID : {id} \n Account Type : {accountType} \n Balance : {balance} \n");        }
    }
}