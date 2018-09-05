using LegoMinifigures.Heads;
using LegoMinifigures.Legs;
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
            var babyLegs = new BabyLegs();
            babyLegs.Length = 19;
            babyLegs.MainColor = "purple";
            babyLegs.ShoeColor = "yellow";

            var bestTeacher = new Minifigure("Nathan",head,reptileBody, babyLegs);

            bestTeacher.Greet();

            var head2 = new MartinHead();
            var birdBody = new BirdTorso();
            birdBody.Color = "pink";
            var manLegs = new Legs.Legs();
            manLegs.Length = 10;
            manLegs.MainColor = "blue";
            manLegs.ShoeColor = "brown";

            var martin = new Minifigure("Martin",head2,birdBody, manLegs);

            martin.Greet();

            bestTeacher.Karate(martin);

            martin.TakeABreak();
            bestTeacher.TakeABreak();
            
            Console.ReadLine();
        }
    }
}
