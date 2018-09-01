using LegoMinifigures.Heads;
using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new NathanHead();

            var figure = new Minifigure(head);

            figure.DoStuff();

            var head2 = new BaldHead();

            var figure2 = new Minifigure(head2);

            figure2.DoStuff();

            Console.ReadLine();
        }
    }
}
