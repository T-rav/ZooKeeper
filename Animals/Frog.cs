using System;

namespace ZooKeeper.Animals
{
    public class Frog : Critter
    {
        public Frog(int age, string color) : base(age, color)
        {
        }

        public override void Eats()
        {
            Console.WriteLine("flies");
        }

        public override void Movement()
        {
            Console.WriteLine("by hop and swiming");
        }
    }
}