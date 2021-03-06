﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Heads
{
    class BaldHead : Head
    {
        private readonly string _name;

        public override bool HasHair { get { return false; } }
        public int SmoothnessLevel { get; set; }

        public BaldHead(string name)
        {
            _name = name;
        }

        public override void Talk(IGreetable greetable)
        {
            Console.WriteLine($"Hi, I'm {_name}!");
            base.Talk(greetable);
        }

        public override void Eat()
        {
            Console.WriteLine("*Eats a burrito*");
        }
    }
}
