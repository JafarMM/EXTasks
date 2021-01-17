using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2
{
    class Helper
    {
        public static void Print(Person person)
        {
            Console.WriteLine($"Ad: {person.FirstName}Soyad: {person.LastName}Yash: {person.Age}Sevdiyi Kitab:{person.myFavoriteBook}");
        }
    }
}