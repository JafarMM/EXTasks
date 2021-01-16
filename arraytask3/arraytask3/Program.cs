using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Menfi ve Musbet ededler yaziniz: ");
                int numbers = Int32.Parse(Console.ReadLine());

                arr[i] = numbers;
            }

            Array.Sort(arr);
            Array.Reverse(arr);

            foreach (int value in arr)
            {
                Console.WriteLine(value);
            }

        }
    }
}