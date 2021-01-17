using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1
{
    class Rabbit : Animal
    {
        public override void GetInfo()
        {
            Console.WriteLine("This is Rabbit");
        }
        public override void Walk()
        {
            Console.WriteLine("Rabbit is Runing...");
        }
        public static void EatingCarrot()
        {
            Console.WriteLine("Rabbit eats carrot");
        }
    }
}