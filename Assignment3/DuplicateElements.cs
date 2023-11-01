using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class DuplicateElements
    {
        static void Main1(string[] args)
        {
            //number of duplicate elements in array
            int[] arr1 = { 1, 2, 2, 2, 3, 4, 5, 5, 3, 6, 7, 6, 8, 7 };
            List<int> list = new List<int>();
            List<int> list1 = new List<int>();

            foreach (int i in arr1)
            {
                if (list.Contains(i) != true)
                {
                    list.Add(i);

                }
                else
                {
                    list1.Add(i);

                }
            }
            Console.WriteLine($"Number of duplicate elements : {list1.Count()}");
        }
    }
}
