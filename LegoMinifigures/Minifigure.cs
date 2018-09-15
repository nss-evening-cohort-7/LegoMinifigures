﻿using LegoMinifigures.Heads;
using LegoMinifigures.Torsos;
using LegoMinifigures.Legs;
using System;

namespace LegoMinifigures
{
    class Minifigure : IGreeter, IGreetable
    {
        private readonly Head _head;
        private readonly Torso _torso;
        private readonly Legs.Legs _legs;

        public string Name { get; }

        public string Description
        {
            get
            {
                return $"{(_head.HasHair ?"Hairy" : "Bald")} {_torso.Color} {_torso.NumberOfArms} armed thing";
            }
        }

        public Minifigure(string name, Head head, Torso torso, Legs.Legs legs)
        {
            Name = name;
            _head = head;
            _torso = torso;
            _legs = legs;
        }

        public void Karate(Minifigure target)
        {
            _legs.Kick(target);
        }

        public void Greet(IGreetable greetable)
        {
            _head.Talk(greetable);
            _torso.Wave();
        }

        public void TakeABreak()
        {
            _head.Eat();

            //var birdTorso = _torso as BirdTorso;
            //if (birdTorso != null)
            //{
            //    birdTorso.Fly();
            //}

            //if (_torso is BirdTorso)
            //{
            //    var birdTorso = (BirdTorso)_torso;
            //    birdTorso.Fly();
            //    birdTorso.Dance();
            //    birdTorso.Fly();
            //}
            //else(_torso is ReptilianTorso) {
            //    var reptilianTorso = (ReptilianTorso)_torso;
            //    reptilianTorso.Dance();
            //}

            switch (_torso)
            {
                case BirdTorso bird:
                    bird.Fly();
                    bird.Dance();
                    bird.Fly();
                    break;
                case ReptilianTorso reptile:
                    reptile.Dance();
                    break;
                case Torso boringTorso:
                    Console.WriteLine($"The boring torso was {boringTorso.Color} and has {boringTorso.NumberOfArms} arms.");
                    break;
            }
        }
    }
}
