using System;

namespace ZooKeeper.Animals
{
    public class Zebra : Critter
    {
        public Zebra(int age, string color) : base(age, color)
        {
        }

        public override void Eats()
        {
            Console.WriteLine("grass");
        }

        public override void Movement()
        {
            Console.WriteLine("on 4 legs");
        }
    }
}