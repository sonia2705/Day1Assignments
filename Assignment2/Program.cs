namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //sum and average of an array
            int[] arr = new int[] { 3, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            int sum = arr.Sum();
            int average = sum / arr.Length;
            Console.WriteLine($"Sum of array is {sum} \n average of array element is {average}");

            //display sum of 3 by 3 matrice
            int[,] arr1 = new int[3, 3] {
            {10, 20, 30} ,
            {40, 50, 70} ,
            {80, 90,110}
            };
            int sum_td = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum_td += arr1[i, j];
                }
            }
            Console.WriteLine($"sum of 3 by 3 is {sum_td}");

            //maximum element of integer array
            int[] arr2 = new int[] { 45, 23, 54, 23, 49, 87 };
            Console.WriteLine($"maximum element of an array is {arr2.Max()}");

            //sum of columnwise elements of array
            int[,] arr4 = new int[3, 4]
            {
                {4,7,2,10 },{ 9,2,3,23},{ 12,15,17,19} };

            int sum_column = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum_column += arr4[j, i];
                }
                Console.WriteLine($"Sum of column {i} : {sum_column}");
            }
            //sum of rowwise elements of array
            int sum_row = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum_row += arr4[i, j];
                }
                Console.WriteLine($"Sum of row {i} : {sum_row}");


            }










        }
    }
}