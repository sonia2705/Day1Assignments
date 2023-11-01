using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace assignment1_s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            //add
            
            Console.WriteLine("enter add a: ");
            int add_A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter add b: ");
            int add_b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"sum is : {add_A+add_b}");
            //subtract
            Console.WriteLine("enter sub a: ");
            int sub_A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter sub b: ");
            int sub_b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"subtract is is : {sub_A - sub_b}");
            //multiply
            Console.WriteLine("enter mult a: ");
            int mult_A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter mult b: ");
            int mult_b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"multiplication  is : {mult_A * mult_b}");
            //divide
            Console.WriteLine("enter div a: ");
            double div_A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter div b: ");
            double div_b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"quotient is : {div_A / div_b}");
            //if-else
            Console.WriteLine("enter CHOICE: ");
            
            int ch=Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("enter add a: ");
                int add_A1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter add b: ");
                int add_b1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"sum is : {add_A1 + add_b1}");

            }
            else if (ch == 2)
            {
                //subtract
                Console.WriteLine("enter sub a: ");
                int sub_A1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter sub b: ");
                int sub_b1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"subtract is is : {sub_A1 - sub_b1}");

            }
            else if(ch == 3)
            {
                //multiply
                Console.WriteLine("enter mult a: ");
                int mult_A1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter mult b: ");
                int mult_b1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"multiplication  is : {mult_A1 * mult_b1}");

            }
            else if(ch == 4)
            {
                Console.WriteLine("enter div a: ");
                double div_A1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter div b: ");
                double div_b1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"quotient is : {div_A1/div_b1}");

            }

            for(int i = 0;i<10; i++)
            {
                Console.WriteLine("Sonia");           }
            int x=1;
            Console.WriteLine("printing even");
            do
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine($"{x}\n");

                }
                x++;
                
            }
            
            while (x < 10);

            int y = 1;
            Console.WriteLine("printing odd");
            do
            {
                if (y % 2 != 0)
                {
                    Console.WriteLine($"{y}\n");

                }

                y++;
            }

            while (x < 10);
            //table using for loop
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"3 * {i} = {3 * i}\n");
            }
            //table using foreach loop
            int[] arr=new int[10] {1,2,3,4,5,6,7,8,9,10};
            foreach(int i in arr)
            {
                Console.WriteLine($"3 * {i} = {3 * i}\n");
            }
            //table using while loop
            int z = 1;
            while (z <= 10)
            {
                Console.WriteLine($"3 * {z} = {3 * z}\n");
                z += 1;
            }
            //table using dowhile loop
            int p = 1;
            do
            {
                Console.WriteLine($"3 * {p} = {3 * p}\n");
                p += 1;
            }
            while (p <= 10);

            //varible declaration and display in one line
            int variable1 = 10;
            int var2 = 12;
            int var3 = 13;
            Console.WriteLine($"Variable is {variable1}. variable2 is {var2}. variable3 is {var3}");
            int variable2 = 20;
            int var4 = 65;
            int var5 = 70;
            Console.WriteLine($"Variable is {variable1} \n variable2 is {var4}\n variable3 is {var5}");




        }



    }
}