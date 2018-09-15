﻿using System;

namespace LegoMinifigures.Heads
{
    abstract class Head
    {
        public abstract bool HasHair { get; }

        public virtual void Talk(IGreetable greetable)
        {
            Console.WriteLine($"I'm a talking head, {greetable.Name}");
        }

        public abstract void Eat();
    }

}
