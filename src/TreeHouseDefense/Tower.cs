using System;

namespace TreeHouseDefense
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = .75;

        private readonly MapLocation _location;
        private static readonly Random _random = new Random();

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccesfulShot() => _random.NextDouble() < _accuracy;

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    string message = string.Empty;

                    if (IsSuccesfulShot())
                    {
                        invader.DecreaseHealth(_power);
                        message = "Hit on target!";

                        if (invader.IsNeutralized)
                        {
                            message = "Invader destroyed!";
                        }
                    }
                    else
                    {
                        message = "Shot missed.";
                    }

                    Console.WriteLine(message);
                    break;
                }
            }
            
        }
    }
}
