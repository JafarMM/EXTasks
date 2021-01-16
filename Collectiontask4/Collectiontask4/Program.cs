using System;
using System.Collections.Generic;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> numbers = new SortedSet<int>();

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Ededler daxil edin:");
                int number = Int32.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            Console.WriteLine("Ededler ugurla daxil edildi.\n");
            Console.WriteLine("|||Sistemdeki ededler|||");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

        }
    }
}
 