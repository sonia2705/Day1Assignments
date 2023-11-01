using System.Xml.Schema;

namespace Assignment3
{
    internal class Electricitybill
    {
        static void Main(string[] args)
        {
            //electricity bill
            Console.WriteLine("Customer ID : ");
            int cust_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Customer name : ");
            string name=Console.ReadLine();
            Console.WriteLine("unit consumed by customer : ");
            int units = Convert.ToInt32(Console.ReadLine());
            int bill = 100;
            double rs;
            double amount;
            double srg=0;
            if (units <= 199)
            {
                rs = 1.20;
                

            }
            else if(units>=200 && units < 400)
            {
                rs = 1.50;
                
            }
            else if(units>=400 && units < 600)

            {
                rs = 1.80;
               
            }
            else
            {
                rs = 2.00;
                srg += units * rs * 0.15;
            }
            amount = units * rs;
            double total = amount + srg;
            if (amount+srg < 100) { total = 100; }
            

            Console.WriteLine($"Customer ID : {cust_id}\n Customer name : {name}\n units consumed : {units}\n Amount Charges @Rs. {rs} per unit : {amount}\n surcharge amount : {srg}\n Net Amount Paid By the Customer : {total}");


        }
    }
}