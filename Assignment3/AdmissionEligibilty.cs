using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class AdmissionEligibilty
    {
        static void Main2(string[] args)
        {
            //number of duplicate elements in array
            Console.WriteLine("Input the marks obtained in Physics : ");
            int phy = byte.Parse(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Chemistry : ");
            int chem = byte.Parse(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Mathematics : ");
            int maths = byte.Parse(Console.ReadLine());
            int total = maths + phy + chem;
            if (maths >= 65 && phy >= 55 && chem >= 50 && total >= 180 || maths + phy >= 140)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
    }
}
