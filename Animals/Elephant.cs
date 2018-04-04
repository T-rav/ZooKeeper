using System;

namespace ZooKeeper.Animals
{
    public class Elephant : Critter
    {
        public Elephant(int age, string color) : base(age, color)
        {
        }

        public override void Eats()
        {
            Console.WriteLine("grass with trunk");
        }

        public override void Movement()
        {
            Console.WriteLine("on 4 legs");
        }
    }
}