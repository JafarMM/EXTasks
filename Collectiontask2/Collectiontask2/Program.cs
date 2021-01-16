using System;
using System.Collections;
using System.Collections.Generic;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
        Elave:
            Console.Write("Adinizi daxil edin: ");
            string name = Console.ReadLine();

            if (names.Count < 10)
            {
                names.Enqueue(name);
                Console.WriteLine("Adinizi ugurla elave etdiniz.");
                Console.WriteLine($"Sistemdeki adlarin Sayi = {names.Count}");

                //Console.WriteLine(names.Peek());
            }
            else
            {
                names.Dequeue();
            }
            Console.Write("Yeni ad daxil etmek isteyirsinizmi (b/x)?");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

            if (consoleKeyInfo.Key == ConsoleKey.X)
            {
                goto Elave;
            }
        }
    }
}