using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Heads
{
    class NathanHead : Head
    {
        public override bool HasHair { get { return true; } }
        public string HairColor { get { return "Salt n Peppa"; } }
        public string Texture { get; set; }

        public override void Eat()
        {
            Console.WriteLine("I never get to eat because of needy students");
        }
    }

}
