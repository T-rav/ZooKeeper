using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper
{
    public class Critter
    {
        protected int Age;
        protected string Color;

        public Critter(int age, string color)
        {
            Age = age;
            Color = color;
        }

        public virtual void Eats()
        {
            Console.WriteLine("never eats");
        }

        public virtual void Movement()
        {
            Console.WriteLine("stationary");
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} (Age={Age}, Color={Color})";
        }
    }
}
