using System;
using System.Collections.Generic;
using System.Threading;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<int> newnumbers = new List<int>();
            List<int> newnumbers1 = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Bir eded daxil ediniz ({i + 1}/10):");
                int number = Int32.Parse(Console.ReadLine());

                numbers.Add(number);
            }
            Console.WriteLine("Edediniz ugurla liste elave olundu");
            Console.WriteLine("Ededlerin yeri deyishdirilir xahish edilir gozleyin.");
            Thread.Sleep(1500);
            for (int i = 5; i < numbers.Count; i++)
            {
                newnumbers.Add(numbers[i]);
            }
            for (int j = 0; j < 5; j++)
            {
                newnumbers1.Add(numbers[j]);
            }

            newnumbers.AddRange(newnumbers1);
            newnumbers.ForEach(Console.WriteLine);
            Console.WriteLine("Ededlerin yeri ugurla deyishdirildi.");
        }

    }
}