using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int counter_positive = 0;
            int counter_negative = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Menfi ve Musbet ededler yaziniz: ");
                int numbers = Int32.Parse(Console.ReadLine());

                arr[i] = numbers;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    counter_negative++;
                }
                else
                {
                    counter_positive++;
                }
            }
            Console.WriteLine($"Menfi ededlerin sayi: {counter_negative}");
            Console.WriteLine($"Musbet ededlerin sayi: {counter_positive}");
        }
    }
}