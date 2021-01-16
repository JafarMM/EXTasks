using System;
using System.Text;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
        Evvel:
            Console.WriteLine("Bir Soz daxil edin:");
            string word = Console.ReadLine().Trim().ToLower();
            string letter_a = "a";
            string letter_b = "b";
            int result1 = word.IndexOf(letter_a, 0, word.Length - 1);
            int result2 = word.IndexOf(letter_b, 0, word.Length - 1);

            if (word.Length != 6)
            {
                Console.WriteLine("Daxil etdiyiniz soz 5 herfden ve sonunda noqteden ibaret olsun...");
                goto Evvel;
            }
            else
            {
                if (result1 != -1)
                {
                    Console.WriteLine("Daxil etdiyiniz sozde a herfi olsun...");
                    goto Evvel;
                }
                else
                {
                    if (result1 != -1)
                    {
                        Console.WriteLine("Daxil etdiyiniz sozde a herfi olmasin...");
                        goto Evvel;
                    }
                    else
                    {
                        if (result2 == -1)
                        {
                            Console.WriteLine("Daxil etdiyiniz sozde en azi bir b herfi olsun...");
                            goto Evvel;
                        }
                        else
                        {
                            if (word.EndsWith('.'))
                            {
                                 

                                string word1 = word.Substring(0, 2);
                                string word2 = word.Substring(word.Length - 4, 3);

                                char[] ch = word1.ToCharArray();
                                StringBuilder sb = new StringBuilder(word2);
                                foreach (char new_word in ch)
                                {
                                    sb.Append(new_word);
                                }
                                Console.WriteLine(sb.ToString());
                            }
                            else
                            {
                                Console.WriteLine("Daxil etdiyiniz soz 5 herfden ve sonda noqteden ibaret olsun...");
                                goto Evvel;

                            }
                        }
                    }
                }
            }
        }
    }
}