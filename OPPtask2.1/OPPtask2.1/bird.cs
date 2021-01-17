using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1
{
    class Bird : Animal
    {
        public override void GetInfo()
        {
            Console.WriteLine("This is bird");
        }
        public override void Walk()
        {
            Console.WriteLine("Bird is jumping");
        }
        public static void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }
}