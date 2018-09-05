using System;

namespace LegoMinifigures.Heads
{
    abstract class Head
    {
        public abstract bool HasHair { get; }

        public virtual void Talk()
        {
            Console.WriteLine("I'm a talking head");
        }

        public abstract void Eat();
    }

}
