using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] arr = new string[3, 3];

            int index0 = arr.GetUpperBound(0);
            int index1 = arr.GetUpperBound(1);
            for (int i = 0; i <= index0; i++)
            {
                for (int j = 0; j <= index1; j++)
                {
                    Console.WriteLine("Kelimeler daxil edin:");
                    arr[i, j] = Console.ReadLine();
                }
            }
            for (int i = 0; i <= index0; i++)
            {
                for (int j = 0; j <= index1; j++)
                {
                    Console.WriteLine(arr[i, j]);
                }
            }
        }
    }
}