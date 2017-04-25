using System;

namespace TreeHouseDefense
{
    class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;

        private readonly MapLocation _location;
        private static readonly Random _random = new Random();

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccesfulShot() => _random.NextDouble() < Accuracy;

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccesfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        

                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Invader destroyed at " + invader.Location + "!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot missed.");
                    }
                    break;
                }
            }
            
        }
    }
}
