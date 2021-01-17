using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();

            bird.GetInfo();
            bird.Walk();
            Bird.Fly();

            Rabbit rabbit = new Rabbit();

            rabbit.GetInfo();
            rabbit.Walk();
            Rabbit.EatingCarrot();
        }
    }
}