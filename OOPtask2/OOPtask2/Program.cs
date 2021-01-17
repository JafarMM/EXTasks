
using System;
using System.Text;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Adınızi daxil ediniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadinizi daxil ediniz:");
            string surname = Console.ReadLine();
            Console.WriteLine("Yashinizi daxil ediniz:");
            byte age = byte.Parse(Console.ReadLine());

            Library library = new Library();

            Person person = new Person(name, surname, age);

            

            Helper.Print(person);
        }
    }
}