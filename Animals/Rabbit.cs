using System;

namespace ZooKeeper.Animals
{
    public class Rabbit : Critter
    {
        public Rabbit(int age, string color) : base(age, color)
        {
        }

        public override void Eats()
        {
            Console.WriteLine("carrots");
        }

        public override void Movement()
        {
            Console.WriteLine("hops");
        }
    }
}