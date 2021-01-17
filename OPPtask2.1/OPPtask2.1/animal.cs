 using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1
{
    abstract class Animal
    {
        public static void Eat()
        {
            Console.WriteLine("Eating...");
        }
        public virtual void Walk()
        {
            Console.WriteLine("Walking");
        }
        public abstract void GetInfo();
    }
}