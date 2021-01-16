using System;
using System.Text;

namespace HomeWork1
{
    class Program
    {
        public static StringBuilder StringBuilder { get; private set; }

        static void Main(string[] args)
        {
        Bashlangic:
            Console.WriteLine("Birinci Reqemi Daxil Edin(3 reqemli eded):");
            string number1 = Console.ReadLine().Trim();
            Console.WriteLine("Ikinci Reqemi Daxil Edin(5 reqemli eded):");
            string number2 = Console.ReadLine().Trim();

            if (number1.Length < 3 || number2.Length < 5)
            {
                Console.WriteLine("Zehmet olmasa birinci reqem yerine 3 ikinciye ise 5 reqem daxil edin.");
                goto Bashlangic;
            }
            else
            {
                number1 = number1.Substring(0, 2);
                number2 = number2.Substring(number2.Length - 4, 4);
                char[] c = number2.ToCharArray();
                StringBuilder s = new StringBuilder(number1);

                foreach (char number in c)
                {
                    s.Append(number);
                }
                int new_number = Int32.Parse(s.ToString());

                int last_numbers = new_number % 1000;
                double first_numbers = new_number / 1000;
                int first_numbers_vol2 = Convert.ToInt32(first_numbers);

                int result = last_numbers - first_numbers_vol2;

                if (result < 0)
                {
                    Console.WriteLine("Netice: " + result);
                    Console.WriteLine("Netice Menfi eded alindi,yeniden yazmaginiz xahish olunur...(Musbet eded yazilmalidir)");
                    goto Bashlangic;
                }
                else
                {
                    Console.WriteLine("Netice: " + result);
                }
            }
        }
    }
}
