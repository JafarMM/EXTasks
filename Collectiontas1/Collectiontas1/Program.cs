using System;
using System.Collections.Generic;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countryCapital = new Dictionary<string, string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Xahish olunur bir olke adi daxil qeyde aliniz({i + 1}/5):");
                string country = Console.ReadLine();
                Console.WriteLine($"Xahish olunur qeyde aldiginiz olkenin paytaxtini daxil edin({i + 1}/5):");
                string capital = Console.ReadLine();

                countryCapital.Add(country, capital);
            }
            Console.WriteLine("Sizi tebrik edirik!Olkenin ve paytaxtin adini duzgun bildiniz!");
        Axtarish:
            Console.Write("Paytaxtini gormek istediyiniz olke adini qeyde alin:");
            string searchCountryName = Console.ReadLine();

            if (searchCountryName.ToLower().Trim() == "all")
            {
                Console.WriteLine("Sistemdeki butun olke ve paytaxtlari");
                foreach (KeyValuePair<string, string> kvp in countryCapital)
                {
                    Console.WriteLine($"Olke: {kvp.Key}\tPaytaxt: {kvp.Value}");
                }
            }
            else
            {
                Console.WriteLine($"Daxil etdiyiniz olkenin paytaxti: {countryCapital.GetValueOrDefault(searchCountryName)}");
            }

            Console.Write("Bir daha axtarish etmek isteyirinizmi?(y/n):");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

            if (consoleKeyInfo.Key == ConsoleKey.Y)
            {
                goto Axtarish;
            }
        }
    }
}