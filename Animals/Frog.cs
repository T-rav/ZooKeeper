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
            Console.WriteLine("hops and swims");
        }

        //public override string ToString()
        //{
        //    return $"Frog (Age={_age},Colour={_color})";
        //}
    }
}