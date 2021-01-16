using System;
using System.Collections.Generic;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sozleri daxil edin: ");
            string words = Console.ReadLine().Trim().ToLower();

            string[] arr = words.Split(' ');

            char letter1 = 'a';
            char letter2 = 'o';

            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                bool result1 = arr[i].Contains(letter1);
                bool result2 = arr[i].Contains(letter2);
                if (result1 == true && result2 == true)
                {

                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        string word = arr[i][j].ToString();
                        int index1 = Array.IndexOf(word.ToCharArray(), letter1);
                        int index2 = Array.IndexOf(word.ToCharArray(), letter2);
                        if (index1 > index2)
                        {
                            Console.WriteLine(arr[i].ToUpper());
                            break;
                        }
                        else if (index1 < index2)
                        {
                            Console.WriteLine(arr[i].ToLower());
                            break;
                        }
                    }

                }
                else if (result1 == true)
                {
                    Console.WriteLine(arr[i].ToUpper());
                }
                else if (result2 == true)
                {
                    Console.WriteLine(arr[i].ToLower());
                }

                else
                {
                    Console.WriteLine(arr[i]);
                }

            }

        }
    }
}