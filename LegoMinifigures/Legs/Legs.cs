using System;

namespace LegoMinifigures.Legs
{
    class Legs
    {
        public int Length { get; set; } = 34;
        public bool HasPants { get; set; } = true;
        public string ShoeColor { get; set; }
        public string MainColor { get; set; }

        public virtual void Walk()
        {
            Console.WriteLine($"The {MainColor} legs walked around the office");
        }

        public virtual void Kick(Minifigure minifigure)
        {
            Console.WriteLine($"The legs kicked {minifigure.Name}, the {minifigure.Description}.");
        }
    }
}
