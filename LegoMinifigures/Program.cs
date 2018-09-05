using LegoMinifigures.Heads;
using LegoMinifigures.Torsos;
using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new NathanHead();
            var reptileBody = new ReptilianTorso();
            reptileBody.Color = "Brown";

            var figure = new Minifigure(head,reptileBody);

            figure.Greet();
            figure.TakeABreak();
            
            Console.ReadLine();
        }
    }
}
